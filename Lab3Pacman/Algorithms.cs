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
		public static long DFS(Coordinate Start, Coordinate Finish, HashSet<Coordinate> visited, List<Coordinate> Path)
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
		public static long Astar(Coordinate Start, Coordinate Finish, HashSet<Coordinate> visited, List<Coordinate> Path)
		{
			using (Process pr = Process.GetCurrentProcess())
			{
				var l = new List<Coordinate>();
				l.Add(Start);
				while (l.Count != 0)
				{
					var currCoor = l.OrderBy(c => c.EstimateFullPathLength).First();
					if (currCoor == Finish)
					{
						
						while (currCoor != null)
						{
							Path.Add(currCoor);
							currCoor = currCoor.Parent;
						}
						Path.Reverse();
						return pr.PrivateMemorySize64;

					}
					l.Remove(currCoor);
					visited.Add(currCoor);
					foreach (Coordinate neigbour in currCoor.Neigbours.Where(x => !visited.Contains(x)))
					{
						var openNode = l.FirstOrDefault(c => c == neigbour);
						neigbour.Parent = currCoor;
						if (openNode == null)
						{
							l.Add(neigbour);
						}
						else
						{
							if (openNode.LengthFromStart > neigbour.LengthFromStart)
							{
								openNode.Parent = currCoor;
								openNode.LengthFromStart = neigbour.LengthFromStart;
							}
						}
					}
				}
				pr.Refresh();
				return pr.PrivateMemorySize64;
			}
		}
		public static long Greedy(Coordinate Start, Coordinate Finish, HashSet<Coordinate> visited, List<Coordinate> Path)
		{
			using (Process pr = Process.GetCurrentProcess())
			{
				var l = new List<Coordinate>();
				l.Add(Start);
				while (l.Count != 0)
				{
					var currCoor = l.OrderBy(c => c.LengthFromLastCoor).First();
					if (currCoor == Finish)
					{

						while (currCoor != null)
						{
							Path.Add(currCoor);
							currCoor = currCoor.Parent;
						}
						Path.Reverse();
						return pr.PrivateMemorySize64;

					}
					l.Remove(currCoor);
					visited.Add(currCoor);
					foreach (Coordinate neigbour in currCoor.Neigbours.Where(x => !visited.Contains(x)))
					{
						var openNode = l.FirstOrDefault(c => c == neigbour);
						neigbour.Parent = currCoor;
						if (openNode == null)
						{
							l.Add(neigbour);
						}
						else
						{
							if (openNode.LengthFromLastCoor > neigbour.LengthFromLastCoor)
							{
								openNode.Parent = currCoor;
								openNode.LengthFromLastCoor = neigbour.LengthFromLastCoor;
							}
						}
					}
				}
				pr.Refresh();
				return pr.PrivateMemorySize64;
			}
		}
	
	}
}
