using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace peach_project_
{
    public static class Statistics
    {

        public static void get_statistics(List<Citizen> pop, String pathOfPit, int iter_number)
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (iter_number == 0)
            {
                if (!Directory.Exists(@pathOfPit + @"statistics/"))
                {
                    Directory.CreateDirectory(@pathOfPit + @"statistics/");
                }

                System.IO.File.WriteAllText(@pathOfPit + @"statistics/stat.xml", String.Empty);

                XmlNode rootNode = xmlDoc.CreateElement("RUN");
                xmlDoc.AppendChild(rootNode);


            }
            else
            {
                xmlDoc.Load(@pathOfPit + @"statistics/stat.xml");

            }
               
                XmlNode iterNode = xmlDoc.CreateElement("ITERATION");
                XmlAttribute attribute = xmlDoc.CreateAttribute("value");
                attribute.Value = iter_number.ToString();
                iterNode.Attributes.Append(attribute);
                xmlDoc.DocumentElement.AppendChild(iterNode);

                XmlNode convNode = xmlDoc.CreateElement("CONVERGENCE");
                attribute = xmlDoc.CreateAttribute("value");
                attribute.Value = check_convergence(pop, pathOfPit).ToString();
                convNode.Attributes.Append(attribute);
                iterNode.AppendChild(convNode);

                XmlNode invNode = xmlDoc.CreateElement("INVALID_PITS");
                attribute = xmlDoc.CreateAttribute("value");
                attribute.Value = check_invalidPits(pop).ToString();
                invNode.Attributes.Append(attribute);
                iterNode.AppendChild(invNode);

                XmlNode avgNode = xmlDoc.CreateElement("AVERAGE_FTNS");
                attribute = xmlDoc.CreateAttribute("value");
                attribute.Value = get_average(pop).ToString();
                avgNode.Attributes.Append(attribute);
                iterNode.AppendChild(avgNode);

                XmlNode faultNode = xmlDoc.CreateElement("FAULT_PITS");
                attribute = xmlDoc.CreateAttribute("value");
                attribute.Value = pitFilesWithFaults(pop).ToString();
                faultNode.Attributes.Append(attribute);
                iterNode.AppendChild(faultNode);


               xmlDoc.Save(@pathOfPit + @"statistics/stat.xml");
        }

        //check how muny groups of identical files are there in the populatio
        public static int check_convergence(List<Citizen> pop, String pathOfPit)
        {
            String first;
            String second;
            int diff;
            int conv = 0;
            List<Citizen> tmp = new List<Citizen>();
            tmp = pop.ToList();
            while (tmp.Count != 0)
            {
                first = readFile(pathOfPit + "pop_" + tmp[0].getIdx().ToString() + ".xml");
                diff = tmp.Count;
                for (int i = 0; i < tmp.Count; i++)
                {
                    second = readFile(pathOfPit + "pop_" + tmp[i].getIdx().ToString() + ".xml");
                    if (first == second)
                    {
                        tmp.RemoveAt(i);
                        i--;
                    }
                }
                diff -= tmp.Count;
                if (diff>0) conv++;
            }
            return conv;
        }

        //check number of invalid pits
        public static int check_invalidPits(List<Citizen> pop)
        {
            int count = 0;
            foreach (Citizen p in pop)
            {
                if (p.getFitness() == 0)
                    count++;
            }

            count = (count * 100) / pop.Count;  //find percent
            return count;
        }


        public static String readFile(String path)
        {
            string readText = File.ReadAllText(path);
            readText.Replace(" ", string.Empty);
            return readText;


        }

        //get average fitness per iteration
        public static double get_average(List<Citizen> pop)
        {
            double average = 0;
            int count = 0;
            foreach (Citizen p in pop)
            {
                if (p.getFitness() > 0)
                {
                    average += p.getFitness();
                    count++;
                }
            }

            if (count > 0)
                average /= count;

            return average;
        
        
        }

        //find percent of peach pits that end with fail
        public static int pitFilesWithFaults(List<Citizen> pop)
        {
            int count = 0;

            foreach (Citizen p in pop)
            {
                if (p.hasFaults())
                    count++;
            }
            count = (count * 100) / pop.Count;  //find percent
            return count;
        }
   }


 
}
