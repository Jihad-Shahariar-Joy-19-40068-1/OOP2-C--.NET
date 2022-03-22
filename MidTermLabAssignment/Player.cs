using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment
{
    class Player
    {
        //Field declaration
        private int rating;
        private int wagePerMatch;
        private int noOfMatches;

        public Player(int rating, int wagePerMatch, int noOfMatches)
        {
            this.rating = rating;
            this.wagePerMatch = wagePerMatch;
            this.noOfMatches = noOfMatches;
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

        //Method declaration
    public string GetTotalEarn()
        {
            return "Total Earnings: " + this.wagePerMatch * this.noOfMatches;
        }
    public string GetPlayerStatus()
        {
            if (this.rating >= 70 && this.noOfMatches >= 10)
            { return "Eligible For bonus"; }
            else { return "Not Eligible"; }
        }
    public string GetSkilledPlayers() //For EmployeeInformationProvider Class
        {
            if (this.rating >= 80)
            { return "Skilled Player"; }
            else { return "Not a Skilled Player"; }
        }
    public string GetPlayer()
        {
            return "Player info: \nRating: " + this.rating + ", Wage Per Match: " + this.wagePerMatch + ", No Of Matches: " + this.noOfMatches;
        }

    }
}
