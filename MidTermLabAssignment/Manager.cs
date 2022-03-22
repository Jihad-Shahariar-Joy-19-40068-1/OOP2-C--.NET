using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment
{
    class Manager
    {
        //Field declaration
        private int rating;
        private int wagePerMatch;
        private int noOfMatches;
        private int yearsOfExperience;

        public Manager(int rating, int wagePerMatch, int noOfMatches, int yearsOfExperience)
        {
            this.rating = rating;
            this.wagePerMatch = wagePerMatch;
            this.noOfMatches = noOfMatches;
            this.yearsOfExperience = yearsOfExperience;
        }
        //Property declaration
        public int Rating
        {
            set { this.rating = value; }
            get { return this.rating; }
        }
        public int WagePerMatch
        {
            set { this.wagePerMatch = 1000; }
            get { return this.wagePerMatch; }
        }
        public int NoOfMatches
        {
            set { this.noOfMatches = value; }
            get { return this.noOfMatches; }
        }
        public int YearsOfExperience
        {
            set { this.yearsOfExperience = value; }
            get { return this.yearsOfExperience; }
        }

        //Method declaration
        public string GetManagerStatus()
        {
            if (this.yearsOfExperience >= 4)
            { return "Eligible For bonus"; }
            else { return "Not Eligible"; }
        }
        public string GetManager()
        {
            return "Manager info: \nRating: " + this.rating + ", Total Earnings: " + this.wagePerMatch * this.noOfMatches + ", No Of Matches: " + this.noOfMatches + ", Years Of Experience: " + this.yearsOfExperience;
        }
    }
}
