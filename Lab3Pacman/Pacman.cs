using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Pacman
{
	interface PacMan
	{
		Coordinate CurrentCoordinate { get; set; }
		Coordinate Start { get; set; }
		Coordinate Finish { get; set; }
		List<Coordinate> Path { get; set; }
		Level Area { get; set; }
		double Cost { get; }
	    long ChooseAlgorithm(String algorithm);
	}
}
