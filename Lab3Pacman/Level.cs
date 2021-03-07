using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Pacman
{
    public class Level
    {
        public List<Coordinate> Area;
    
        public Level(int[,] area)
        {
            int n = area.GetLength(0);
            int m = area.GetLength(1);
            Area = new List<Coordinate>();  
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    bool IsFree = area[i, j] == 0;
                    var c = new Coordinate(i, j, IsFree, 1);
                    Area.Add(c);
                }
            }
            for (int i = 0; i < Area.Count; i++)
            {
                Area[i].Neigbours = new List<Coordinate>();
                for (int j = 0; j < Area.Count; j++)
                {
                    if (Coordinate.IsNeighbors(Area[i], Area[j]) && Area[j].IsFree)
                    {
                    
                        Area[i].Neigbours.Add(Area[j]);
                    }
                }
            }
           
        }
      
    }
}
