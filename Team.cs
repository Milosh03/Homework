using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMeThisFootball
{
    internal class Team
    {
        private List<FootballPlayer> players;
        private Coach coach;
        public List<FootballPlayer> Players
        {
            get { return this.players; }
            set
            {
                if (value.Count < 11 && value.Count > 22)
                {
                    throw new Exception("Minimum 11, Maximum 22!");
                }
                this.players = value;
            }
        }
        public Coach Coach
        {
            get { return this.coach; }
            set { this.coach = value; }
        }
        public int AverageAge(List<FootballPlayer> players)
        {
            int average = 0;
            for (int i = 0; i < players.Count; i++)
            {
                average += players[i].Age;
            }
            return average / 11;
        }
        public Team(Coach coach, List<FootballPlayer> players)
        {
            this.coach = coach;
            this.players = players;
        }
    }
}
