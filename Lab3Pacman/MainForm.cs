using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab3Pacman
{
    public partial class MainForm : Form
    {
        PacmanImpl pacman;
        Level area;
        int pixelSizeH;
        int pixelSizeW;
        Bitmap bgBitmap;
        const int n=36;
        const int m=36;
        int[,] intArea;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pacmanBox.Parent = levelBox;
            intArea = new int[n, m];
            pixelSizeW = levelBox.Size.Width / n;
            pixelSizeH = levelBox.Size.Height / m;
            bgBitmap = new Bitmap(levelBox.Size.Width, levelBox.Size.Height);
            pacmanBox.Size = new Size(pixelSizeW, pixelSizeH);
        }

        private void MoveAndDraw()
        {
            pacmanBox.Location = new Point(pixelSizeW * pacman.Start.X, pixelSizeH * pacman.Start.Y);
            while (pacman.Move())
            {
                pacmanBox.Location = new Point(pixelSizeW * pacman.CurrentCoordinate.X, pixelSizeH * pacman.CurrentCoordinate.Y);
                levelBox.Refresh();
                System.Threading.Thread.Sleep(5);
            }
        }

        private void BFSButton_Click(object sender, EventArgs e)
        {
            button("BFS");
            if (pacman.Path.Count > 1)
            {
                MoveAndDraw();
            }
            else
            {
                MessageBox.Show("Cant find path!", "Problem");
            }
        }

        private void DFSButton_Click(object sender, EventArgs e)
        {

            button("DFS");
            if (pacman.Path.Count > 1)
            {
                MoveAndDraw();
            }
            else
            {
                MessageBox.Show("Cant find path!", "Problem");
            }
        }
        private void Astar_Click(object sender, EventArgs e)
        {
            button("A");
            if (pacman.Path.Count > 1)
            {
                MoveAndDraw();
            }
            else
            {
                MessageBox.Show("Cant find path!", "Problem");
            }
        }
        private void Greedy_Click(object sender, EventArgs e)
        {
            button("Greedy");
            if (pacman.Path.Count > 1)
            {
                MoveAndDraw();
            }
            else
            {
                MessageBox.Show("Cant find path!", "Problem");
            }
        }

        private void createAreaButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (rand.NextDouble() < 0.9)
                    {
                        intArea[i, j] = 0;
                    }
                    else
                    {
                        intArea[i, j] = 1;
                    }
                }
            }
            area = new Level(intArea);
            pacman = new PacmanImpl
            {
                Path = new List<Coordinate>(),
                Start = area.Area.First(x => (x.X == 0 && x.Y == 0)),
                CurrentCoordinate = area.Area.First(x => (x.X == 0 && x.Y == 0)),
                Area = area,
                Finish = area.Area.First(x => (x.X == (n - 10) / 2 && x.Y == n - 1 ))
            };
            foreach(Coordinate c in area.Area)
            {
                c.LengthFromStart = Coordinate.FindDistance(pacman.Start, c);
                c.HeuristicLengthToFinal = Coordinate.FindDistance(pacman.Finish, c);
            }
            pacmanBox.Location = new Point(pixelSizeW * pacman.Start.X, pixelSizeH * pacman.Start.Y);
            Graphics bgGraphics = Graphics.FromImage(bgBitmap);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    var brush = intArea[i, j] == 0 ? Brushes.Black : Brushes.Green;
                    if (pacman.Finish.X == i && pacman.Finish.Y == j)
                        brush = Brushes.Red;
                    bgGraphics.FillRectangle(
                        brush,
                        i * pixelSizeH,
                        j * pixelSizeW,
                        pixelSizeH,
                        pixelSizeW);
                }
            }
            levelBox.Image = bgBitmap;
            pacman.Area = area;
            dfsButton.Enabled = true;
            bfsButton.Enabled = true;
            Astar.Enabled = true;
            Greedy.Enabled = true;
        }


    private void button(String algorithm)
        {
            var sw = new Stopwatch();
            sw.Start();
            long memory = pacman.ChooseAlgorithm(algorithm);
            sw.Stop();
            var t = sw.ElapsedMilliseconds;
            elapsedLabel.Text = string.Format("{0} ms", t.ToString());
            elapsedLabel.Refresh();
            memLabel.Text = string.Format("{0} b", getMemory(memory));
        }
     private static long getMemory(long memory)
        {
            long FormMemory;
            using (Process p = Process.GetCurrentProcess())
            {
                FormMemory = p.PrivateMemorySize64;
            }
            return FormMemory - memory;
        }

        private void levelBox_Click(object sender, EventArgs e)
        {

        }

       
    }
}
