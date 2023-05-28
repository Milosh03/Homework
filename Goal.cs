using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMeThisFootball
{
    internal class Goal
    {
        private FootballPlayer player;
        private int minute;
        public FootballPlayer Player
        {
            get { return this.player; }
            set { this.player = value; }
        }
        public int Minute
        {
            get { return this.minute; }
            set { this.minute = value; }
        }
        public Goal(FootballPlayer player, int minute)
        {
            this.player = player;
            this.minute = minute;
        }
        public string ToString()
        {
            return $"{Player.Name} scored in {Minute} minute";
        }
    }
}
