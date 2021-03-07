using System;
using System.Collections.Generic;

namespace Lab3Pacman
{
    public class Coordinate
    {
        public Int32 X { get; set; }
        public Int32 Y { get; set; }
        public Int32 Cost { get; set; }
        public List<Coordinate> Neigbours { get; set; }
        public Coordinate Parent { get; set; }
        public bool IsFree { get; set; }
        public Coordinate()
        {

        }
        public Coordinate(Int32 x , Int32 y , bool isFree , Int32 cost)
        {
            this.X = x;
            this.Y = y;
            this.IsFree = isFree;
            this.Cost = cost;
        }
        public static bool IsNeighbors( Coordinate a, Coordinate b)
        {
            return FindDistance(a,b) == 1;
        }
        private static Int32 FindDistance(Coordinate a, Coordinate b)
        {
            return (Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y));

        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Coordinate c = (Coordinate)obj;
                return (X == c.X) && (Y == c.Y);
            }
        }
        public override int GetHashCode()
        {
            return 3 * (X + Y);
        }
    }

}
