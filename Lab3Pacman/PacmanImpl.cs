using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Lab3Pacman
{
	
	public class PacmanImpl : PacMan
	{
		public double Cost { get { return Path.Sum(x => x.Cost); } }
		public Coordinate CurrentCoordinate { get; set; }

		private int currentIndex = 0;
		public Coordinate Start { get; set; }
		public List<Coordinate> Path { get; set; }
		public Coordinate Finish { get; set; }
		public Level Area { get; set; }
        private HashSet<Coordinate> Visited;
		public PacmanImpl()
        {
			Visited = new HashSet<Coordinate>();
        }
		
		public long ChooseAlgorithm(String algorithm)
		{
			DeleteResult();
			if (algorithm == "BFS")
			{
				return Algorithms.BFS(Start, Finish, Visited, Path);
			}
			else if(algorithm == "DFS")
			{
				return Algorithms.DFS(Start, Finish, Visited, Path);
			}
			else { return 0; }
		}
		public bool Move()
        {
			if (Path.Count <= currentIndex)
				return false;
			CurrentCoordinate = Path[currentIndex];
			currentIndex++;
			return true;
        }
		private void DeleteResult()
		{
			CurrentCoordinate = Start;
			currentIndex = 0;
			Path.Clear();
			Visited.Clear();
			Visited.Add(Start);
			foreach (Coordinate c in Area.Area)
			{
				c.Parent = null;
			}
		}
	}

}
