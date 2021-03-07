using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Pacman
{
    class Algorithms
    {
		public static long DFS(Coordinate Start , Coordinate Finish, HashSet<Coordinate> visited ,List<Coordinate> Path)
		{
			using (Process pr = Process.GetCurrentProcess())
			{
				
				var s = new Stack<Coordinate>();
				s.Push(Start);
				while (s.Count != 0)
				{
					var coordinate = s.Pop();
					foreach (Coordinate neigbour in coordinate.Neigbours.Where(x => !visited.Contains(x)))
					{
						s.Push(neigbour);
						visited.Add(neigbour);
						neigbour.Parent = coordinate;
						if (neigbour.Equals(Finish))
						{
							Coordinate buff = neigbour;
							while (buff != null)
							{
								Path.Add(buff);
								buff = buff.Parent;
							}
							Path.Reverse();
							return pr.PrivateMemorySize64;
						}
					}
				}
				return pr.PrivateMemorySize64;
			}
		}
		public static long BFS(Coordinate Start, Coordinate Finish, HashSet<Coordinate> visited, List<Coordinate> Path)
		{
			var q = new Queue<Coordinate>();
			q.Enqueue(Start);

			while (q.Count != 0)
			{
				var coordinate = q.Dequeue();
				foreach (Coordinate neigbour in coordinate.Neigbours.Where(x => !visited.Contains(x)))
				{
					q.Enqueue(neigbour);
					visited.Add(neigbour);
					neigbour.Parent = coordinate;
					if (neigbour.Equals(Finish))
					{
						Coordinate buff = neigbour;
						while (buff != null)
						{
							Path.Add(buff);
							buff = buff.Parent;
						}
						Path.Reverse();
						using (Process pr = Process.GetCurrentProcess())
						{
							pr.Refresh();
							return pr.PrivateMemorySize64;
						}
					}
				}
			}
			using (Process pr = Process.GetCurrentProcess())
			{
				pr.Refresh();
				return pr.PrivateMemorySize64;
			}
		}
	}
}
