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
        IEnumerable<XElement> DMblocks;
        IEnumerable<XElement> Testblocks;
        double fitness;
        int index;


        public Citizen()
        {
            this.fitness = -1;
            this.index = -1;
            DMblocks = null;
            Testblocks = null;
        }

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

        public void setFitness(double fitness)
        {
            this.fitness = fitness;
        }

        public double getFitness()
        {
            return fitness;
        }

        public void setIdx(int idx)
        {
            this.index = idx;
        }

        public double getIdx()
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
    }
}
