using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMeThisFootball
{
    internal class FootballPlayer : Person
    {
        
            private int number;
            private double height;

            public int Number
            {
                get { return this.number; }
                set { this.number = value; }
            }
            public double Height
            {
                get { return this.height; }
                set { this.height = value; }
            }
            public FootballPlayer(string name, int age, int number, double height) : base(name, age)
            {
                this.number = number;
                this.height = height;
            }
        
    }
}
