using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                var lines = File.ReadAllLines(@"C:\Users\Nithya\Documents\Visual Studio 2017\Projects\Football\Football\football.csv").Skip(1).Select(x => x.Split(',')).ToList();

                var teamScores = new List<Scores>();

                lines.ForEach(x => teamScores.Add(new Scores(x[0], int.Parse(x[1]), int.Parse(x[2]), int.Parse(x[3]), int.Parse(x[4]), int.Parse(x[5]), x[6], int.Parse(x[7]), int.Parse(x[8]))));

                var team = teamScores.OrderBy(x => x.Difference).Select(x => x.TeamName).FirstOrDefault();
                Console.WriteLine($"\n The team with smallest difference in 'for' and 'against' goals is : {team.ToString()}");
                Console.ReadKey();

            }
            catch(Exception ex)
            {
                Console.WriteLine($"The following Exception has occured : \n {ex}");
                Console.ReadKey();
            }
        }
    }
}
