using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RattlerControl1
{
    public enum WATER_STATE { Stop, In, Out };
    public enum ROTATE_STATE { Stop, ForwardRotating, ReversaRotating };
    public enum HEAT_STATE { END, ING };

    public partial class Rattler : UserControl
    {
        public Rattler()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.ResizeRedraw |
                        ControlStyles.AllPaintingInWmPaint, true);
        }

        private double waterLevel;

        public double WaterLevel
        {
            get { return waterLevel; }
            set { waterLevel = value; this.Refresh(); }
        }

        private WATER_STATE waterState;

        public WATER_STATE WaterState
        {
            get { return waterState; }
            set { waterState = value; this.Refresh(); }
        }

        private ROTATE_STATE rotateState;

        public ROTATE_STATE RotateState
        {
            get { return rotateState; }
            set { rotateState = value; this.Refresh(); }
        }


        private float angle;

        public float Angle
        {
            get { return angle; }
            set { angle = value; this.Refresh(); }
        }

        private float rotateSpd = 3;

        public float RotateSpd
        {
            get { return rotateSpd; }
            set { rotateSpd = value; this.Refresh(); }
        }

        private HEAT_STATE heatState;

        public HEAT_STATE HeatState
        {
            get { return heatState; }
            set { heatState = value; this.Refresh(); }
        }

        private Color reder = Color.FromArgb(0, 0, 0);
        private void Rattler_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (heatState == HEAT_STATE.ING)
            {
                reder = Color.FromArgb(reder.R + 2 > 255 ? 255 : reder.R + 2, 0, 0);
                g.DrawRectangle(new Pen(reder, 3), 0, -3, this.Width - 3, this.Height);
            }
            else
            {
                reder = Color.FromArgb(0, 0, 0);
                g.DrawRectangle(new Pen(reder, 3), 0, -3, this.Width - 3, this.Height);
            }

            int waterHeight = (int)(waterLevel / 100.0 * this.Height);
            Rectangle waterRect = new Rectangle(2, this.Height - waterHeight - 4, this.Width - 6, waterHeight);
            g.FillRectangle(Brushes.SkyBlue, waterRect);

            Image imgFans = Properties.Resources.风扇;

            int xPos = (this.Width - imgFans.Width) / 2;
            int yPos = (this.Height - imgFans.Height) / 2;

            Point imgRotateCenterPos = new Point(imgFans.Width / 2, imgFans.Height / 2);
            Rectangle rcShow = new Rectangle(xPos, yPos, imgFans.Width, imgFans.Height);

            PointF centerPos = new Point(imgRotateCenterPos.X + rcShow.Left, imgRotateCenterPos.Y + rcShow.Top);

            g.TranslateTransform(centerPos.X, centerPos.Y);
            g.RotateTransform(angle);
            g.TranslateTransform(-centerPos.X, -centerPos.Y);

            g.DrawImage(imgFans, rcShow.Left, rcShow.Top, rcShow.Width, rcShow.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (WaterState == WATER_STATE.In)
            {
                WaterLevel += 1;

                if (WaterLevel >= 100.0)
                {
                    WaterLevel = 100.0;
                }
            }

            if (WaterState == WATER_STATE.Out)
            {
                WaterLevel -= 1;

                if (WaterLevel <= 0.0)
                {
                    WaterLevel = 0.0;
                }
            }

            if (RotateState == ROTATE_STATE.ForwardRotating)
            {
                Angle += rotateSpd;
            }

            if (RotateState == ROTATE_STATE.ReversaRotating)
            {
                Angle -= rotateSpd;
            }
        }
    }
}
