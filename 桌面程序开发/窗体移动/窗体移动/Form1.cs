using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
using Point = System.Drawing.Point;

namespace 窗体移动
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Tuple<int, int>> dir;
        Direction direction;
        private void Form1_Load(object sender, EventArgs e)
        {
            dir = new List<Tuple<int, int>>();
            dir.Add(new Tuple<int, int>(-1, 0));
            dir.Add(new Tuple<int, int>(-1, -1));
            dir.Add(new Tuple<int, int>(0, -1));
            dir.Add(new Tuple<int, int>(1, -1));
            dir.Add(new Tuple<int, int>(1, 0));
            dir.Add(new Tuple<int, int>(1, 1));
            dir.Add(new Tuple<int, int>(0, 1));
            dir.Add(new Tuple<int, int>(-1, 1));
            direction = Direction.RightTop;
            this.Location = new Point(519, 315);
            this.TopMost = true;
            StartTimer.Enabled = true;
            StartTimer.Start();
        }
        private int i = 0, count;
        private Image bgImg = null, gif;
        private System.Drawing.Imaging.FrameDimension fd;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (i >= count) i = 0;
            gif.SelectActiveFrame(fd, i);
            System.IO.Stream stream = new System.IO.MemoryStream();
            gif.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            if (bgImg != null) { bgImg.Dispose(); }
            bgImg = Image.FromStream(stream);
            this.BackgroundImage = new Bitmap(bgImg, this.Size);
            i++;
        }
        private void StartTimer_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();

            gif = Properties.Resources.bck;
            fd = new System.Drawing.Imaging.FrameDimension(gif.FrameDimensionsList[0]);
            count = gif.GetFrameCount(fd);
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 200;
            timer.Tick += Timer_Tick;
            timer.Start();

            StartTimer.Stop();
            StartTimer.Enabled = false;
        }

        private enum Windows_collide_location
        {
            Not, Top, Left, Right, Bottom
        }
        private enum Direction
        {
            Left = 0,
            LeftTop = 1,
            Top = 2,
            RightTop = 3,
            Right = 4,
            RightBottom = 5,
            Bottom = 6,
            LeftBottom = 7
        }
        private Windows_collide_location collide_state()
        {
            Rectangle p = Screen.GetWorkingArea(this);
            //Console.WriteLine(direction.ToString() + ", " + (int)direction + "->" + this.Top + ", " + this.Left + ", " + this.Right + ", " + this.Bottom + " <_>" + p.Top + ", " + p.Left + ", " + p.Right + ", " + p.Bottom);
            if (this.Top <= p.Top &&
                (direction == Direction.LeftTop || direction == Direction.RightTop || direction == Direction.Top))
                return Windows_collide_location.Top;
            if (this.Left <= p.Left &&
                (direction == Direction.Left || direction == Direction.LeftTop || direction == Direction.LeftBottom))
                return Windows_collide_location.Left;
            if (this.Right >= p.Right &&
                (direction == Direction.Right || direction == Direction.RightTop || direction == Direction.RightBottom))
                return Windows_collide_location.Right;
            if (this.Bottom >= p.Bottom &&
                (direction == Direction.Bottom || direction == Direction.LeftBottom || direction == Direction.RightBottom))
                return Windows_collide_location.Bottom;

            return Windows_collide_location.Not;
        }
        private void collide()
        {
            Windows_collide_location state = collide_state();
            if (state == Windows_collide_location.Not) return;
            if (state == Windows_collide_location.Top)
            {
                switch (direction)
                {
                    case Direction.Top:
                        direction = Direction.Bottom;
                        break;
                    case Direction.LeftTop:
                        direction = Direction.LeftBottom;
                        break;
                    case Direction.RightTop:
                        direction = Direction.RightBottom;
                        break;
                }
            }
            else if (state == Windows_collide_location.Left)
            {
                switch (direction)
                {
                    case Direction.Left:
                        direction = Direction.Right;
                        break;
                    case Direction.LeftTop:
                        direction = Direction.RightTop;
                        break;
                    case Direction.LeftBottom:
                        direction = Direction.RightBottom;
                        break;
                }
            }
            else if (state == Windows_collide_location.Right)
            {
                switch (direction)
                {
                    case Direction.Right:
                        direction = Direction.Left;
                        break;
                    case Direction.RightTop:
                        direction = Direction.LeftTop;
                        break;
                    case Direction.RightBottom:
                        direction = Direction.LeftBottom;
                        break;
                }
            }
            else if (state == Windows_collide_location.Bottom)
            {
                switch (direction)
                {
                    case Direction.Bottom:
                        direction = Direction.Top;
                        break;
                    case Direction.LeftBottom:
                        direction = Direction.LeftTop;
                        break;
                    case Direction.RightBottom:
                        direction = Direction.RightTop;
                        break;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine(this.Location.X + ", " + this.Location.Y);
            }
        }

        private void move()
        {
            this.Location = 
                new System.Drawing.Point(this.Location.X + dir[(int)direction].Item1, 
                this.Location.Y + dir[(int)direction].Item2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            collide();
            move();
        }
    }
}
