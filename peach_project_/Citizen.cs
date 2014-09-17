using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Globalization;

namespace peach_project_
{
    public class Citizen
    {
        //Fields of the object of type Citizen. 
        IEnumerable<XElement> DMblocks;
        IEnumerable<XElement> Testblocks;
        double fitness;
        int age;
        int index;
        bool faults;
     

        //constructor of class Citizen
        public Citizen()
        {
            this.fitness = 0;
            this.index = -1;
            this.age = 0;
            DMblocks = null;
            Testblocks = null;
            this.faults = false;

        }

        //set and get blocks of information from xml file
        public void setDMBlocks(IEnumerable<XElement> blocks)
        {
            this.DMblocks = blocks;
        }

        public IEnumerable<XElement> getDMBlocks()
        {
            return this.DMblocks;
        }

        public void setTestBlocks(IEnumerable<XElement> blocks)
        {
            this.Testblocks = blocks;
        }

        public IEnumerable<XElement> getTestBlocks()
        {
            return this.Testblocks;
        }

        //set and get fitness value of the citizen
        public void setFitness(double fitness)
        {
            this.fitness = fitness;
        }

        public double getFitness()
        {
            return fitness;
        }


        //set index of the citizen
        public void setIdx(int idx)
        {
            this.index = idx;
        }

        public int getIdx()
        {
            return this.index;
        }

        public int count()
        {
            int count = 0;
            foreach (var block in this.DMblocks)
            {
                count++;
            }
            return count;
        }

        //set and get age of the citizen
        public void increaseAge()
        {
            this.age++;
        }

        public int getAge()
        {
            return this.age;
        }

        //set and check whether usagage of the citizen ended with a fault
        public void setFaults(bool fault)
        {
            this.faults = fault;
        }

        public bool hasFaults()
        {
            return this.faults;
        }
       
    }
}
