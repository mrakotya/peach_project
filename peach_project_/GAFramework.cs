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
        public static readonly int GA_POPSIZE = 5;		// ga population size
        public static readonly int GA_MAXITER = 50;		// maximum iterations
        public static readonly double GA_ELITRATE = 0.10;	// elitism rate
        public static readonly double GA_MUTATIONRATE = 0.25;	// mutation rate
        public static readonly int RAND_MAX = 0x7fff;
        public static readonly double GA_MUTATION = RAND_MAX * GA_MUTATIONRATE;
        public static readonly String GA_TARGET = "";
        public static readonly int MAX_ITERCOUNTER = 1000;
        public static readonly int SURVIVAL_AGE = 5;
        public static readonly double S_FOR_LINEARRANKING = 1.5;
        public static readonly double THRESHOLD = 0.5;
        public static readonly Double AVG_DIFF = 0.15; // average difference between two generations in percentage
        public static readonly Double STD_DIFF = 0.15;
        String pathOfPit;
        String OriginalPitFile;
        Dictionary<string, string> data_vector = new Dictionary<string, string>();
        string data_line;
        List<Citizen> pop = new List<Citizen>();
        List<Citizen> buffer = new List<Citizen>();

        public void start(int population, String logsPath, String PathOfPit,  String OriginalPitFile, String PeachTestRange)
        {
            System.IO.DirectoryInfo downloadedMessageInfo = new System.IO.DirectoryInfo(@logsPath);

            foreach (System.IO.DirectoryInfo dir in downloadedMessageInfo.GetDirectories())
            {
                dir.Delete(true);
            }
            foreach (System.IO.FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }
            this.pathOfPit = PathOfPit;
            this.OriginalPitFile = OriginalPitFile;
            init_population(population, pop);
            calc_fitness(pathOfPit, pop, logsPath, PeachTestRange);
            sort_by_fitness();
            mate(pop, buffer, 1, 1, true, 1);
        }

        public void calc_fitness(String pathOfPit, List<Citizen> pop, String logsPath, String PeachTestRange)
        {
            int len = pop.Count;
            len = 2;
            double counter = 0;
            double temp = 0;
            System.IO.File.WriteAllText(@logsPath + "path_to_file.txt", String.Empty);
            for(int i=0; i<pop.Count; i++)
            {
            var path = Environment.ExpandEnvironmentVariables(@"C:\Users\Masha\Downloads\peach_svn\peach.bat");
            var parms = "--range=1," + PeachTestRange +" " + pathOfPit + "pop_" + i + ".xml";
            var process = Process.Start(path, parms);
            process.WaitForExit();   
            //Console.ReadKey();
            }
            Console.WriteLine("\nGet test time info from status.txt\n");
            Console.WriteLine("Loading all data into memory\n");
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
                        }
                    }
                }
                pop[Convert.ToInt32(entry.Key.Split('.')[0].Split('_')[1])].setFitness(counter);
                counter = 0;

            }
            //=========================================================================================================================================
            Process[] ps = Process.GetProcessesByName("python");
            foreach (Process p in ps)
                p.Kill();
        
        }



        public void init_population(int population, List<Citizen> pop)
        {
            //later to do: path as a function start parameter
            for(int i= 0; i<5; i++)
            {
                XDocument peachPit = XDocument.Load(@OriginalPitFile);
             
             var DataModelblocks = peachPit.XPathSelectElements("Peach/DataModel");
             var Testblocks = peachPit.Descendants("Test");
            foreach (var block in DataModelblocks)
            {
                switch (block.Name.ToString().ToLower())
                {
                    case "block":
                        block_(block);
                        break;
                    case "blob":
                        blob_(block);
                        break;
                    case "choice":
                        break;
                    case "custom":
                        break;
                    case "flag":
                        break;
                    case "flags":
                        break;
                    case "number":
                        break;
                    case "padding":
                        break;
                    case "string":
                        string_(block);
                        break;
                    case "relation":
                        break;
                    case "fixup":
                        break;
                    case "transformer":
                        break;
                    case "placement":
                        break;
                    default:
                        Console.WriteLine("ERROR:UNKNOWN TAG");
                        break;
                }

            }

            String fileName = "pop_" + i +".xml";
            peachPit.Save(pathOfPit + fileName);
            Citizen c = new Citizen();
            c.setDMBlocks(DataModelblocks);
            c.setTestBlocks(Testblocks);
            c.setIdx(i);
            pop.Add(c);
            }
        }


        private void block_(XElement el)
        {
            //minoccurs  maxOccurs
            Random rnd = new Random();
            int val;
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                minMaxOccurs(el);
            }
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                mutable(el);
            }
        }


        private void blob_(XElement el)
        {
            //minoccurs  maxOccurs
            int val;
            Random rnd = new Random();
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                minMaxOccurs(el);
            }
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                mutable(el);
            }
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                token(el);
            }
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                value_(el);
            }


        }

        void string_(XElement el)
        {
            //minoccurs  maxOccurs
            int val;
            Random rnd = new Random();
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                minMaxOccurs(el);
            }
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                mutable(el);
            }
            val = rnd.Next(1, 100);
            if (val % 2 == 0)
            {
                token(el);
            }
            val = rnd.Next(1, 100);
         
                value_(el);
            

        }


        private void minMaxOccurs(XElement el)
        {
            int minValue = -1, maxValue = -1;
            if (el.Attribute("maxOccurs") != null)
            {
                maxValue = Convert.ToInt32(el.Attribute("maxOccurs").Value.ToString());
            }
            if (el.Attribute("minOccurs") != null)
            {
                minValue = Convert.ToInt32(el.Attribute("minOccurs").Value.ToString());
            }

            Random rnd = new Random();
            if (maxValue != -1 && minValue == -1)
            {
                maxValue = rnd.Next(1, maxValue);
                el.Attribute("maxOccurs").SetValue(maxValue.ToString());
            }
            else if (maxValue != -1 && minValue != -1)
            {
                maxValue = rnd.Next(minValue, maxValue);
                el.Attribute("maxOccurs").SetValue(maxValue.ToString());
            }
            if (minValue != -1 && maxValue == -1)
            {
                minValue = rnd.Next(minValue, minValue * 2);
                el.Attribute("minOccurs").SetValue(minValue.ToString());
            }
            else if (minValue != -1 && maxValue != -1)
            {
                minValue = rnd.Next(minValue, maxValue);
                el.Attribute("minOccurs").SetValue(minValue.ToString());
            }
        }


        private void mutable(XElement el)
        {
            if (el.Attribute("mutable") != null)
            {
                if (el.Attribute("mutable").Value.ToString().Equals("false"))
                {
                    el.Attribute("mutable").SetValue("true");
                }
            }
            else
            {
                XAttribute attribute = new XAttribute("mutable", "false");
                el.Add(attribute);
            }
        }

        private void token(XElement el)
        {
            if (el.Attribute("token") != null)
            {
                if (el.Attribute("token").Value.ToString().Equals("false"))
                {
                    el.Attribute("token").SetValue("true");
                }
                else el.Attribute("token").SetValue("false");
            }

        }


        private void value_(XElement el)
        {
            String type;
            String StrValue;
            int length;
            Random rnd = new Random();

            if (el.Attribute("valueType") == null)
            {
                type = "string";
            }
            else type = el.Attribute("valueType").Value.ToString();
            if (el.Attribute("value") != null)
            {
                switch (type.ToLower())
                {
                    case "string":
                        length = rnd.Next(1, 100);
                        StrValue = crString(length);
                        el.Attribute("value").SetValue(StrValue);
                        break;
                    case "hex":
                        int b;
                        b = Convert.ToInt32(el.Attribute("value").Value.ToString(), 16);
                        b = rnd.Next(0, Math.Abs(b));
                        StrValue = b.ToString("x");
                        el.Attribute("value").SetValue(StrValue);
                        break;
                    case "literal":
                        break;
                    default:
                        Console.WriteLine("Error:Wnknown Type");
                        break;
                }
            }

        }

        private String crString(int length)
        {
            Random rnd = new Random();
            StringBuilder b = new StringBuilder();
            for (int j = 0; j < length; j++)
            {
                char c = (char)(rnd.Next(90) + 32);
                b.Append(c);
            }
            return b.ToString();

        }


        private int fitness_sort(Citizen x, Citizen y)
        {
            if (x.getFitness() > y.getFitness()) return 1;
            else if (x.getFitness() == y.getFitness()) return 0;
            else return -1;
        }

        private void sort_by_fitness()
        {
            pop.Sort(fitness_sort);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        void mate(List<Citizen> population, List<Citizen> buffer, int selectionStrategy, int crossoverStrategy, Boolean linearRanking, int SurvivalStrategy)
        {
            int esize = (int)(GA_POPSIZE * GA_ELITRATE);
          //  bool scaled = false;
            Citizen child = new Citizen();
            List<Citizen> parents = new List<Citizen>();


     /*       for (int i = 0; i < GA_POPSIZE; i++)
            {
                parents.Clear();
                //survival strategy
                switch (SurvivalStrategy)
                {
                    case 0: //no strategy
                        //do nothing
                        break;
                    case 1: //elitism
                        if (i == 0)
                        {
                            elitism(population, buffer, esize);
                            i += esize;
                        }
                        break;
                    case 2: //aging
                        if (i == 0)
                        {
                            aging(population, buffer, esize);
                            i += esize;
                        }
                        break;
                    case 3: //genitor
                        if (i == 0)
                        {
                            genitor(population, buffer, population.Count - esize);
                            i += population.Count - esize;
                        }
                        break;
                }*/

                // selection
                switch (selectionStrategy)
                {
                    case 1: // fps
                        //do scaling only once
                       /* if (scaled == false)
                        {
                            expScalling(population);
                            scaled = true;
                        }*/
                        parents = fps(population);
                        break;
                    /*case 2: // tournament
                        parents = tournament(population, linearRanking);
                        break;
                    case 3: // threshold
                        parents = threshholdSelection(population);
                        break;*/
                }

          
                    switch (crossoverStrategy)
                    {
                        case 1: // uniform crossover
                            child = uniform(parents);
                            break;
                      //  case 1: // one point crossover
                       //     child = onepoint(parents);
                       //     break;

                    }
                
                buffer.Add(child);
                // mutation

            /*    if (rand.Next() < GA_MUTATION)
                {
                    mutate(buffer[i]);
                }
            }*/
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private Citizen uniform(List<Citizen> parents)
        { 

            //XDocument first = XDocument.Load(@"C:\Users\Masha\Downloads\peach_svn\samples\mutated\pop_" + parents[0].getIdx().ToString() +".xml");
           // XDocument second = XDocument.Load(@"C:\Users\Masha\Downloads\peach_svn\samples\mutated\pop_" + parents[1].getIdx().ToString() +".xml");
            XDocument first = XDocument.Load(@"C:\Users\Masha\Downloads\peach_svn\samples\mutated\pop_1.xml");
            XDocument second = XDocument.Load(@"C:\Users\Masha\Downloads\peach_svn\samples\mutated\pop_0.xml");
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
                        //des_second.Single().SetAttributeValue("name", "KAKA");
                        des_first.ReplaceWith(des_second);
                    }
                }
                    
                }
               
            }

           
            first.Save(@"C:\Users\Masha\Downloads\peach_svn\samples\mutated\dump.xml");

            //child.setBlocks();
            return null;
     
        }



        List<Citizen> fps(List<Citizen> population)
        { // aka RWS
            double totalFitness = 0;
            Random rand = new Random();
            List<Citizen> parents = new List<Citizen>();

            foreach (Citizen citizen in population)
            {
                totalFitness += citizen.getFitness();
            }

            double rnd = rand.NextDouble() * totalFitness;
            int idx;

            for (idx = 0; idx < GA_POPSIZE - 1 && rnd > 0; idx++)
            {
                rnd -= population[idx].getFitness();
            }
            parents.Add(population[population.Count - 1 - idx]);
            // select 2nd individual
            rnd = rand.NextDouble() * totalFitness;
            for (idx = 0; idx < GA_POPSIZE - 1 && rnd > 0; idx++)
            {
                rnd -= population[idx].getFitness();
            }
            parents.Add(population[population.Count - 1 - idx]);
            return parents;

        }

    }
}