using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars
{
    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }
        public Enums.Directions Directon { get; set; }

        public Position() 
        {
            this.x = 0;
            this.y = 0;

            this.Directon = Enums.Directions.N;
        }
        private void SpinLeft()  //Assuming 90 degree
        {
            switch (this.Directon)
            {
                case Enums.Directions.N:
                    this.Directon = Enums.Directions.W;
                    break;
                case Enums.Directions.S:
                    this.Directon = Enums.Directions.E;
                    break;
                case Enums.Directions.E:
                    this.Directon = Enums.Directions.N;
                    break;
                case Enums.Directions.W:
                    this.Directon = Enums.Directions.S;
                    break;
                default:
                    break;
            }
        }

        private void SpinRight()  //Assuming 90 degree
        {
            switch (this.Directon)
            {
                case Enums.Directions.N:
                    this.Directon = Enums.Directions.E;
                    break;
                case Enums.Directions.S:
                    this.Directon = Enums.Directions.W;
                    break;
                case Enums.Directions.E:
                    this.Directon = Enums.Directions.S;
                    break;
                case Enums.Directions.W:
                    this.Directon = Enums.Directions.N;
                    break;
                default:
                    break;
            }
        }

        private void MoveForward()     // Move forwar or back one point
        {
            switch (this.Directon)
            {
                case Enums.Directions.N:  // move one point from y coordinate
                    this.y += 1;
                    break;
                case Enums.Directions.S:  // move back one point from y coordinate
                    this.y -= 1;
                    break;
                case Enums.Directions.E:  // move one point from x coordinate
                    this.x += 1;
                    break;
                case Enums.Directions.W:  // move back one point from x coordinate
                    this.x -= 1;
                    break;
                default:
                    break;
            }
        }

        public void StartMove(List<int> maxPoints, string moves)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        this.MoveForward();
                        break;
                    case 'L':
                        this.SpinLeft();
                        break;
                    case 'R':
                        this.SpinRight();
                        break;
                    default:                       
                        break;
                }

                if (this.x < 0 || this.y > maxPoints[0] || this.y < 0 || this.x > maxPoints[1])
                {
                    throw new Exception();
                }
            }
        }
    }
}
