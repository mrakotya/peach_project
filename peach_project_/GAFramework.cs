using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Globalization;
using System.Diagnostics;

namespace peach_project_
{
    public class GAFramework
    {
        //fields of class GAFramework
        public static readonly int RAND_MAX = 0x7fff;
        String pathOfPit;
        String logsPath;
        String PeachTestRange;
        String OriginalPitFile;
        Dictionary<string, string> data_vector = new Dictionary<string, string>();
        string data_line;
        List<Citizen> pop_list = new List<Citizen>();
        List<Citizen> buffer = new List<Citizen>();
        Random rnd = new Random(DateTime.Now.Millisecond);
        int BadGenesChildrenNumberToMake;
        int elitrate;
        bool useGenotor;
        int genrate;
        int maxAge;
        bool withScaling;
        double GAmutate;
        int iterarions;
        int faults_counter;
        String peach_cmd;
 
        //function starting the session run
        public void start(Parameters parm)
        {
            Random rand = new Random();
            //get all parameters
            this.elitrate = parm.getElitrate();
            useGenotor = false;
            this.genrate = parm.getGenrate();
            this.logsPath = parm.getLogsPath();
            this.PeachTestRange = parm.getPeachTestRange();
            this.maxAge = parm.getMaxAge();
            this.withScaling = parm.getWithScaling();
            this.GAmutate = parm.getMutationRate()*RAND_MAX;
            this.iterarions = parm.getIterations();
            faults_counter = 0;
            this.pathOfPit = parm.getPathOfPitPopulation();
            this.OriginalPitFile = parm.getPitfilePath();
            this.peach_cmd = parm.getPeachFuzzerPlatformPath();

            //clear logs from prefious runs and prepare directory children faults 
            System.IO.DirectoryInfo downloadedMessageInfo = new System.IO.DirectoryInfo(@logsPath);

            foreach (System.IO.DirectoryInfo dir in downloadedMessageInfo.GetDirectories())
            {
                dir.Delete(true);
            }
            foreach (System.IO.FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }

            downloadedMessageInfo = new System.IO.DirectoryInfo(@pathOfPit);

            foreach (System.IO.DirectoryInfo dir in downloadedMessageInfo.GetDirectories())
            {
                dir.Delete(true);
            }
            foreach (System.IO.FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }


            if (!System.IO.Directory.Exists(@pathOfPit + @"children/"))
            {
                System.IO.Directory.CreateDirectory(@pathOfPit + @"children/");
            }
            if (!System.IO.Directory.Exists(@pathOfPit + @"faults/"))
            {
                System.IO.Directory.CreateDirectory(@pathOfPit + @"faults/");
            }

            init_population(parm.getPopulation(), pop_list);



            //start running
                for (int j = 0; j < this.iterarions; j++)
                {
                calc_fitness(pathOfPit, pop_list, logsPath, PeachTestRange);//calculate fitness
                sort_by_fitness();//sort population by fitness value
                Statistics.get_statistics(pop_list, pathOfPit, j);
                if (pop_list[0].getFitness() > 0)
                {
                    mate(pop_list, buffer, parm.getParentsChoiceStrategy(), 1, true, parm.getSurvivalStrategy(), parm.getBadGenesChildren());          
                    pop_list = buffer.ToList();
                    buffer.Clear();

                }
                else //if all peach pits are invalid, restart session
                {
                    pop_list.Clear();
                    init_population(parm.getPopulation(), pop_list);
                    j = -1;
                    System.Windows.Forms.MessageBox.Show("All pit files are invalid. Session will be restarted.");

                }
           }
        }

        //calculate fitness
        private void calc_fitness(String pathOfPit, List<Citizen> pop, String logsPath, String PeachTestRange)
        {
            int len = pop.Count;
            len = 2;
            double counter = 0;
            bool fault_detected = false;
            
            data_vector.Clear();
            
            System.IO.File.WriteAllText(@logsPath + "path_to_file.txt", String.Empty);
            for(int i=0; i<pop.Count; i++)
            {
            var path = Environment.ExpandEnvironmentVariables(peach_cmd);
            var parms = "--range=1," + PeachTestRange +" " + pathOfPit + "pop_" + i.ToString() + ".xml"; //parameters for the peach fuzzer platform cmd
           
                var process = Process.Start(path, parms);
                process.WaitForExit();
           
            }
            

            string[] lines = System.IO.File.ReadAllLines(@logsPath + "path_to_file.txt");

            foreach (string line in lines)
            {
                data_vector.Add(line.Split('-')[0], line.Split(':')[1]);
            }

            foreach (KeyValuePair<string, string> entry in data_vector)
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(@entry.Value))
                {

                    while ((data_line = file.ReadLine()) != null)
                    {
                        if (data_line.Contains("Average test case time"))
                        {
                            counter += Convert.ToDouble(data_line.Split(':').Last());
                        }
                        else if (data_line.Contains("Fault was detected on test"))
                        {
                            counter ++;
                            fault_detected = true;

                        }
                    }
                }
                pop[Convert.ToInt32(entry.Key.Split('.')[0].Split('_')[1])].setFitness(counter);
                String rem = @"\status.txt";
                int index = entry.Value.IndexOf(rem);
               
                if (fault_detected)
                {
                    //here keep file with fault 
                    String SoursePath = (index < 0) ? entry.Value : entry.Value.Remove(index, rem.Length);
                    CopyDir.Copy(SoursePath, pathOfPit + @"faults/" + faults_counter.ToString());
                    System.IO.File.Copy(pathOfPit + "pop_" + entry.Key.Split('.')[0].Split('_')[1] + ".xml", pathOfPit + @"faults/" + faults_counter.ToString() + "/pop_" + entry.Key.Split('.')[0].Split('_')[1] + ".xml");
                    faults_counter++;
                    pop[Convert.ToInt32(entry.Key.Split('.')[0].Split('_')[1])].setFaults(true);
                    fault_detected = false;

                }
                counter = 0;
               

              
            }

            //delete logs from current iteration
            System.IO.DirectoryInfo downloadedMessageInfo = new System.IO.DirectoryInfo(@logsPath);

            foreach (System.IO.DirectoryInfo dir in downloadedMessageInfo.GetDirectories())
            {
                dir.Delete(true);
            }
            foreach (System.IO.FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }
        
            Process[] ps = Process.GetProcessesByName("python");
            foreach (Process p in ps)
                p.Kill();
        
        }


        //initialize population
        private void init_population(int population, List<Citizen> pop)
        {
            for(int i= 0; i<population; i++)
            {
              XDocument peachPit = XDocument.Load(@OriginalPitFile);
              MutationFunctions.mutate(peachPit, rnd);          
            String fileName = "pop_" + i +".xml";
            peachPit.Save(pathOfPit + fileName);
            Citizen c = new Citizen();
            // c.setDMBlocks(DataModelblocks);
            //c.setTestBlocks(Testblocks);
            c.setIdx(i);
            pop.Add(c);
            }
        }

        //sorting functions
        private int fitness_sort(Citizen x, Citizen y)
        {
            if (x.getFitness() < y.getFitness()) return 1;
            else if (x.getFitness() == y.getFitness()) return 0;
            else return -1;
        }

        private void sort_by_fitness()
        {
            pop_list.Sort(fitness_sort);
            
        }
        
        //breeding, i.e. selecting to parents and creating a child
        void mate(List<Citizen> population, List<Citizen> buffer, int selectionStrategy, int crossoverStrategy, Boolean linearRanking, int SurvivalStrategy, int BadGenesChildren)
        {
            
            Citizen child = new Citizen();
            List<Citizen> parents = new List<Citizen>();

            List<Citizen> temp = new List<Citizen>();
            temp = population.FindAll(x => x.getFitness() > 0);
            int esize = (int)(temp.Count() * elitrate / 100);
            BadGenesChildrenNumberToMake = (population.Count() - esize) * BadGenesChildren / 100;
            int gensize = (int)(population.Count() * genrate / 100);
            int oldIdx;
            bool scaling;
               if (withScaling == true)
                   scaling = false;
               else scaling = true;

            for (int i = 0; i < population.Count(); i++)
            {
                parents.Clear();
                //survival strategy
                 switch (SurvivalStrategy)
                  {
                      case 0: //elitism
                          if (i == 0)
                          {
                              elitism(population, buffer, esize);
                              i += esize;
                              
                          }
                          break;
                      case 1: //aging
                          if (i == 0)
                          {
                              aging(population, buffer, esize);
                              i += esize;
                          }
                          break;
                      case 2: //genitor
                          useGenotor = true;
                          break;
                  }

               
                // selection
                switch (selectionStrategy)
                {
                    case 0:
                        parents = naive(population);
                        break;
                    case 1:
                         if (scaling == false)
                        {
                            expScalling(population);
                            scaling = true;
                        }
                        parents = fps(population);
                        break;
                    case 2: // tournament
                        parents = tournament(population, linearRanking);
                        break;
                }


                switch (crossoverStrategy)
                {
                    case 1: // uniform crossover

                        child = crossover(parents, buffer.Count);
                        break;
                }



                if (useGenotor == false)
                {
                    int k = rnd.Next(0, RAND_MAX);
                if (k < GAmutate) //is there necessity in mutation?
                {
                    XDocument peachPit = XDocument.Load(pathOfPit + @"children\pop_" + child.getIdx().ToString() + ".xml");
                    MutationFunctions.mutate(peachPit, rnd);
                    peachPit.Save(pathOfPit + @"children\pop_" + child.getIdx().ToString() + ".xml");
                }
                    buffer.Add(child);
               }
                else//use genitor
                {
                    if (gensize > 0)
                    {
                        oldIdx = child.getIdx();
                        child.setIdx(population[population.Count()-1].getIdx());
                        population.RemoveAt(population.Count() - 1);
                        System.IO.File.Delete(pathOfPit + "pop_" + child.getIdx().ToString() + ".xml");
                        population.Add(child);
                        calc_fitness(pathOfPit, population, logsPath, PeachTestRange);
                        sort_by_fitness();
                        System.IO.File.Copy(pathOfPit + @"children\pop_" + oldIdx.ToString() + ".xml", pathOfPit +"pop_" + child.getIdx().ToString() + ".xml", true);
                        System.IO.File.Delete(pathOfPit+ @"children\pop_" + oldIdx.ToString() + ".xml");
                        gensize--;
                    }
                    else break;
                    
                }
               
            }
        
            CopyFolderContents(pathOfPit + "children", pathOfPit); //copy all children to the current population directory       
        }


       //make crossover
        private Citizen crossover(List<Citizen> parents, int index)
        { 
            Citizen child = new Citizen();
            XDocument first = XDocument.Load(pathOfPit +"pop_" + parents[0].getIdx().ToString() +".xml");
            XDocument second = XDocument.Load(pathOfPit +"pop_" + parents[1].getIdx().ToString() +".xml");

            var DataModelblocks_first = first.XPathSelectElements("Peach/DataModel");
            var DataModelblocks_second = second.XPathSelectElements("Peach/DataModel");

            foreach (var block_first in DataModelblocks_first)
            {
                
                var block_second =
                    (from el in DataModelblocks_second
                    where (string)el.Attribute("name") == block_first.Attribute("name").Value
                    select el);

                foreach (var des_first in block_first.Descendants().ToList())
                {
                    if (des_first.Attribute("name") != null)
                    {
                    var des_second =
                   from el in block_second.Descendants()
                   where (string)el.Attribute("name") == des_first.Attribute("name").Value
                   select el;
                    if (des_second != null)
                    {
                        int val;
                        val = rnd.Next(1, 100);
                        if (val % 2 == 0)
                        {
                            des_first.ReplaceWith(des_second);
                        }
                    }
                }
                    
                }
               

            }

            first.Save(pathOfPit + @"children\pop_" + index+  ".xml");
            child.setDMBlocks(DataModelblocks_first);
            child.setIdx(index);
            return child;
     
        }


        //naive choice of parents, that is parents are selected randomly
        List<Citizen> naive(List<Citizen> population)
        {
            List<Citizen> parents = new List<Citizen>();
            List<Citizen> temp = new List<Citizen>();
            temp = population.FindAll(x=> x.getFitness()>0);


            for(int i=0; i<2; i++)
                {
                    int rand = rnd.Next(0, population.Count);
                    if(BadGenesChildrenNumberToMake==0)
                         {
                                               
                            rand = rnd.Next(0, temp.Count);
                            parents.Add(temp[rand]);
                         }
                     else
                         {
                                 parents.Add(population[rand]);
                                 BadGenesChildrenNumberToMake--;
                
                         }
            }
           
            return parents;
        }

        //fps selection strategy
        List<Citizen> fps(List<Citizen> population)
        { // aka Roulette
            double totalFitness = 0;
            double partialSum = 0;
            int idx = 0;
       
            
            List<Citizen> parents = new List<Citizen>();

            foreach (Citizen citizen in population)
            {
                totalFitness += citizen.getFitness();
            }

     
            double rand = rnd.NextDouble() * totalFitness;
            while(rand > partialSum)
            {
                partialSum += population[idx].getFitness();
                idx++;
            }
            parents.Add(population[idx-1]);
            // select 2nd individual
            rand = rnd.NextDouble() * totalFitness;
            partialSum = 0;
            idx = 0;
            while (rand > partialSum)
            {
                partialSum += population[idx].getFitness();
                idx++;
            }
            parents.Add(population[idx-1]);

            return parents;

        }

      //elitism survival
       void elitism(List<Citizen> population, List<Citizen> buffer, int esize)
        {
           
            for (int i = 0; i < esize; i++)
            {
                Citizen child = new Citizen();
                child.setFitness(population[i].getFitness());
                child.setIdx(i);
                buffer.Add(child);
                System.IO.File.Copy(pathOfPit +  "pop_" + child.getIdx().ToString() + ".xml", pathOfPit + @"children\pop_" + i.ToString() + ".xml", true);
            }
           
        }

        //make scaling
       private void expScalling(List<Citizen> population)
       {
           double fitness = 0;
           foreach (Citizen citizen in population)
           {
               if(citizen.getFitness()>0)
               fitness = Math.Sqrt(citizen.getFitness());
               citizen.setFitness(fitness);
           }
       }

      //aging survival strategy
       private void aging(List<Citizen> population, List<Citizen> buffer, int esize)
       {
           int i = 0;
           while (i < esize && i<population.Count)
           {
               if (population[i].getAge() <= maxAge)
               {
                   population[i].increaseAge();
                   buffer.Add(population[i]);
               }
               else
               {
                   esize++;
               }
               i++;
           }
       }



       private List<Citizen> tournament(List<Citizen> population, Boolean linearRanking)
       {
           List<Citizen> parents = new List<Citizen>();
           int citezen_num, best_citizen;
           double best_fit;
           int x = rnd.Next(8) + 2; // select x members from current population(range from 2 to 10)
           //now 2 best citizens are to be chosen from the group of x
           best_citizen = rnd.Next(population.Count);
           best_fit = population[best_citizen].getFitness();
           for (int i = 0; i < x; i++)
           {
               citezen_num = rnd.Next(population.Count);
               if (population[citezen_num].getFitness() > best_fit)
               {                
                       best_citizen = citezen_num;
                       best_fit = population[citezen_num].getFitness();
               }

           }

           parents.Add(population[best_citizen]); // for first parent

           best_citizen = rnd.Next(population.Count);
           best_fit = population[best_citizen].getFitness();

           for (int i = 0; i < x; i++)
           {
               citezen_num = rnd.Next(population.Count);
               if (population[citezen_num].getFitness() > best_fit)
               {
                       best_citizen = citezen_num;
                       best_fit = population[citezen_num].getFitness();
               }

           }
           parents.Add(population[best_citizen]); // for second parent

           return parents;

       }
        

        
        
//===============================================================Extra Functions==========================================================================
        public static void CopyFolderContents(string sourceFolder, string destinationFolder)
        {
            if (System.IO.Directory.Exists(sourceFolder))
            {
                // Copy folder structure
                foreach (string sourceSubFolder in System.IO.Directory.GetDirectories(sourceFolder, "*", System.IO.SearchOption.AllDirectories))
                {
                    System.IO.Directory.CreateDirectory(sourceSubFolder.Replace(sourceFolder, destinationFolder));
                }

                // Copy files
                foreach (string sourceFile in System.IO.Directory.GetFiles(sourceFolder, "*", System.IO.SearchOption.AllDirectories))
                {
                    string destinationFile = sourceFile.Replace(sourceFolder, destinationFolder);
                    System.IO.File.Copy(sourceFile, destinationFile, true);
                }



                System.IO.DirectoryInfo downloadedMessageInfo = new System.IO.DirectoryInfo(@sourceFolder);
                foreach (System.IO.FileInfo file in downloadedMessageInfo.GetFiles())
                {
                    file.Delete();
                }

            }
        }

    }
}