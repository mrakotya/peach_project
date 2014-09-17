using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace peach_project_
{
    public class Parameters
    {
        //Fields of the object of type Parameters. 
        //Class was created to simplify passing parameters from GUI to GA Framework module

        String logsPath;
        String PathOfPitPopulation;
        String originalPitFile;
        String peachTestRange;
        String PitFilePath;
        String PeachFuzzerPlatformPath;

        int BadGenesChildren;
        int population;
        int parentsChoiceStrategy;
        int elitrate;
        int survivalStrategy;
        int genrate;
        int maxAge;
        bool withScaling;       
        double mutationRate;
        int iterations;
        

        //constructor of the class
          public Parameters()
        {
            logsPath = "";
            population = -1;
            PathOfPitPopulation = "";
            originalPitFile = "";
            peachTestRange = "";
            BadGenesChildren =- 1; ;
            parentsChoiceStrategy = -1;
            elitrate = -1;
            survivalStrategy = -1;
            genrate = -1;
            maxAge = -1;
            withScaling = false;
            PitFilePath="";
            mutationRate = -1;
            iterations = -1;
            PeachFuzzerPlatformPath = "";
        }

        //get and set path to save logs of the Peach Fuzzer Platform
        public void setLogsPath(String logsPath)
        {
            this.logsPath = logsPath;
        }

        public String getLogsPath()
        {
            return this.logsPath;
        }


        //get and set Population Number
        public void setPopulation(int population)
        {
            this.population = population;
        }

        public int getPopulation()
        {
            return this.population;
        }

        //get and set path to save population Peach Pit Files
        public void setPathOfPitPopulation(String PathOfPitPopulation)
        {
            this.PathOfPitPopulation = PathOfPitPopulation;
        }

        public String getPathOfPitPopulation()
        {
            return this.PathOfPitPopulation;
        }


        //get and set path to the Peach Pit file to be used for creation initial population
        public void setOriginalPitFile(String originalPitFile)
        {
            this.originalPitFile = originalPitFile;
        }

        public String getOriginalPitFile()
        {
            return this.originalPitFile;
        }


        //get and set number of tests to run on each citizen
        public void setPeachTestrange(String peachTestRange)
        {
            this.peachTestRange = peachTestRange;
        }

        public String getPeachTestRange()
        {
            return this.peachTestRange;
        }


        //get and set number of children that can have invalid Peach Pit files as parents
        public void setBadGeneschildren(int BadGenesChildren)
        {
            this.BadGenesChildren = BadGenesChildren;
        }

        public int getBadGenesChildren()
        {
            return this.BadGenesChildren;
        }


        //get and set Parents Selection Strategy
        public void setParentsChiceStrategy(int parentsChoiceStrategy)
        {
            this.parentsChoiceStrategy = parentsChoiceStrategy;
        }

        public int getParentsChoiceStrategy()
        {
            return this.parentsChoiceStrategy;
        }

        //get and set percent of elitism
        public void setElitrate(int elitrate)
        {
            this.elitrate = elitrate;
        }

        public int getElitrate()
        {
            return this.elitrate;
        }

        //get and set seurvival strategy
        public void setSurvivalStrategy(int survivalStrategy)
        {
            this.survivalStrategy = survivalStrategy;
        }

        public int getSurvivalStrategy()
        {
            return this.survivalStrategy;
        }

        //get and set genitor rate
        public void setGenrate(int genrate)
        {
            this.genrate = genrate;
        }

        public int getGenrate()
        {
            return this.genrate;
        }

        //get and set maximum age for aging survival strategy
        public void setMaxAge(int maxAge)
        {
            this.maxAge = maxAge;

        }
        public int getMaxAge()
        {
            return this.maxAge;
        }

        //set using scaling for FPS, check whether it is set
        public void setWithScaling(bool withScaling)
        {
            this.withScaling = withScaling;
        }

        public bool getWithScaling()
        {
            return this.withScaling;
        }


        //get and set pit file path
        public void setpitFilepath(String PitFilePath)
        {
            this.PitFilePath = PitFilePath;
        }
        public String getPitfilePath()
        {
            return this.PitFilePath;
        }


        //get and set mutation rate
        public void setMutationRate(double mutationRate)
        {
            this.mutationRate = mutationRate;
        }

        public double getMutationRate()
        {
            return this.mutationRate;
        }


        //get and set number of iterations
        public void setIterations(int iterations)
        {
            this.iterations = iterations;
        }

        public int getIterations()
        {
            return this.iterations;
        }


        //get and set command of the Peach Fuzze platform
        public void setPeachFuzzerPlatformPath(String path)
        {
            this.PeachFuzzerPlatformPath = path;
        }
        public String getPeachFuzzerPlatformPath()
        {
            return this.PeachFuzzerPlatformPath;
        }

    }
}
