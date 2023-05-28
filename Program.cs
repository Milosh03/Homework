using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMeThisFootball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coach coach1 = new Coach("Karim Benzema No.", 16);
            List<FootballPlayer> players1 = new List<FootballPlayer>();
            FootballPlayer footballPlayer1 = new Goalkeeper("Milosh", 27, 11, 1.97);
            FootballPlayer footballPlayer2 = new Defender("Nikola", 21, 26, 1.83);
            FootballPlayer footballPlayer3 = new Defender("Anton", 22, 77, 1.76);
            FootballPlayer footballPlayer4 = new Defender("Nikolay", 24, 76, 1.83);
            FootballPlayer footballPlayer5 = new Striker("Georgi", 23, 12, 1.70);
            FootballPlayer footballPlayer6 = new Striker("Stefan", 24, 44, 1.93);
            FootballPlayer footballPlayer7 = new Striker("Hasan", 22, 13, 1.82);
            FootballPlayer footballPlayer8 = new Defender("Verhat", 26, 12, 1.76);
            FootballPlayer footballPlayer9 = new Midfielder("Ahmed", 21, 76, 1.82);
            FootballPlayer footballPlayer10 = new Midfielder("Boris", 20, 10, 1.75);
            FootballPlayer footballPlayer11 = new Midfielder("Ivan" , 25, 54, 1.84);

            players1.Add(footballPlayer1);
            players1.Add(footballPlayer2);
            players1.Add(footballPlayer3);
            players1.Add(footballPlayer4);
            players1.Add(footballPlayer5);
            players1.Add(footballPlayer6);
            players1.Add(footballPlayer7);
            players1.Add(footballPlayer8);
            players1.Add(footballPlayer9);
            players1.Add(footballPlayer10);
            players1.Add(footballPlayer11);


            Team team1 = new Team(coach1, players1);
            Console.Write("Team 1 Coach: ");
            Console.Write(team1.Coach.Name + " " + team1.Coach.Age);
            Console.WriteLine();
            Console.WriteLine("Team 1 Squad:");
            foreach (var item in players1)
            {
                Console.WriteLine("No." + item.Number + " " + item.Name);
            }
            Console.WriteLine();
            Console.WriteLine("The average age of the players from Team 1 is: " + team1.AverageAge(players1) + " years");

            Coach coach2 = new Coach("Lionel Messi, No.", 10);
            List<FootballPlayer> players2 = new List<FootballPlayer>();
            FootballPlayer footballPlayer12 = new Goalkeeper("Martin ", 22, 11, 1.82);
            FootballPlayer footballPlayer13 = new Defender("David ", 23, 23, 1.78);
            FootballPlayer footballPlayer14 = new Defender("Georgi ", 24, 12, 1.83);
            FootballPlayer footballPlayer15 = new Defender("Plamen ", 19, 41, 1.80);
            FootballPlayer footballPlayer16 = new Midfielder("Kiril ", 24, 63, 1.72);
            FootballPlayer footballPlayer17 = new Midfielder("Filip ", 25, 22, 1.73);
            FootballPlayer footballPlayer18 = new Midfielder("Petko ", 27, 32, 1.81);
            FootballPlayer footballPlayer19 = new Striker("Nikolay " , 23, 14, 1.94);
            FootballPlayer footballPlayer20 = new Striker("Teodor ", 20, 17, 1.69);
            FootballPlayer footballPlayer21 = new Midfielder("Filip ", 31, 16, 1.86);
            FootballPlayer footballPlayer22 = new Defender("David ", 29, 77, 1.91);

            players2.Add(footballPlayer12);
            players2.Add(footballPlayer13);
            players2.Add(footballPlayer14);
            players2.Add(footballPlayer15);
            players2.Add(footballPlayer16);
            players2.Add(footballPlayer17);
            players2.Add(footballPlayer18);
            players2.Add(footballPlayer19);
            players2.Add(footballPlayer20);
            players2.Add(footballPlayer21);
            players2.Add(footballPlayer22);

            Team team2 = new Team(coach2, players2);
            Console.WriteLine();
            Console.Write("Team 2 coach: ");
            Console.Write(team2.Coach.Name + " " + team2.Coach.Age);
            Console.WriteLine();
            Console.WriteLine("Team 2 Squad:");
            foreach (var item in team2.Players)
            {
                Console.WriteLine("No." + item.Number + " " + item.Name);
            }
            Console.WriteLine();
            Console.WriteLine("The average age of the players from Team 2 is: " + team2.AverageAge(players2) + " years");
            Console.WriteLine();
            Referee referee = new Referee("Neymar Jr. No.", 13);
            Referee assistantReferee1 = new Referee("Kyllian Mbappe No.", 13);
            Referee assistantReferee2 = new Referee("Sergio Ramos No.", 20);

            List<Referee> referees = new List<Referee>();
            referees.Add(referee);
            referees.Add(assistantReferee1);
            referees.Add(assistantReferee2);

            Console.WriteLine("Referees: ");
            foreach (var item in referees)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }

            Goal goal1 = new Goal(footballPlayer6, 11);
            Goal goal2 = new Goal(footballPlayer18, 66);
            Goal goal3 = new Goal(footballPlayer7, 89);

            List<Goal> goals = new List<Goal>();
            goals.Add(goal1);
            goals.Add(goal2);
            goals.Add(goal3);

            int team1Goals = 0;
            int team2Goals = 0;

            Console.WriteLine();
            foreach (var item in goals)
            {
                if (team1.Players.Contains(item.Player))
                {
                    team1Goals++;
                    Console.WriteLine(item.ToString());
                    Console.WriteLine($"Result: {team1Goals}:{team2Goals}");
                }
                else
                {
                    team2Goals++;
                    Console.WriteLine(item.ToString());
                    Console.WriteLine($"Result: {team1Goals}:{team2Goals}");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Final Result: {team1Goals}:{team2Goals}!");
            if (team1Goals > team2Goals)
            {
                Console.WriteLine("Team 1 are the winners");
            }
            else if (team1Goals < team2Goals)
            {
                Console.WriteLine("Team 2 are the winners");
            }
            else
            {
                Console.WriteLine("Draw");
            }

        }

    }
}
