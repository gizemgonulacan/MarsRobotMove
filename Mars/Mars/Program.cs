using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars
{
    class Program
    {
        static void Main(string[] args)
        {
            var UpperLowerPoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var startPositions = Console.ReadLine().Trim().Split(' ');
            Position position = new Position();

            if (startPositions.Count() == 3)
            {
                position.x = Convert.ToInt32(startPositions[0]);
                position.y = Convert.ToInt32(startPositions[1]);
                position.Directon = (Enums.Directions)Enum.Parse(typeof(Enums.Directions), startPositions[2]);
            }

            var moves = Console.ReadLine().ToUpper();

            try
            {
                position.StartMove(UpperLowerPoints, moves);
                Console.WriteLine($"{position.x} {position.x} {position.Directon.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
