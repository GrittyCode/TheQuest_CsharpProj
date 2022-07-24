using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    abstract class Mover
    {
        private const int m_MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; }  }
        protected Game game;


        //생성자
        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        //
        public bool Nearby(Point locationToCheck, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance &&
                Math.Abs(location.Y - locationToCheck.Y) < distance)
                return true;
            else
                return false;
        }

        public bool Nearby(Point locationToCheck, Point target, int distance)
        {
            if (Math.Abs(target.X - locationToCheck.X) < distance &&
                Math.Abs(target.Y - locationToCheck.Y) < distance)
                return true;
            else
                return false;
        }
        public Point Move(Direction dir, Rectangle bound)
        {
            Point newLocation = location;
            switch (dir)
            {
                case Direction.Up:
                    if (newLocation.Y - m_MoveInterval >= bound.Top)
                        newLocation.Y -= m_MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + m_MoveInterval <= bound.Bottom)
                        newLocation.Y += m_MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - m_MoveInterval >= bound.Left)
                        newLocation.X -= m_MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + m_MoveInterval <= bound.Right)
                        newLocation.X += m_MoveInterval;
                    break;
                default:
                    break;
            }

            return newLocation;

        }

        public Point Move(Direction dir, Point target, Rectangle bound)
        {
            Point newLocation = target;
            switch (dir)
            {
                case Direction.Up:
                    if (newLocation.Y - m_MoveInterval >= bound.Top)
                        newLocation.Y -= m_MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + m_MoveInterval <= bound.Bottom)
                        newLocation.Y += m_MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - m_MoveInterval >= bound.Left)
                        newLocation.X -= m_MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + m_MoveInterval <= bound.Right)
                        newLocation.X += m_MoveInterval;
                    break;
                default:
                    break;
            }

            return newLocation;

        }
    }
}
