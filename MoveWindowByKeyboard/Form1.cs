using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveWindowByKeyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.W)
            {
                if (Location.Y - 50 > 0)
                    Location = new Point(Location.X, Location.Y - 50);
                else
                    Location = new Point(Location.X, 0);
            }
            else if (e.KeyData == Keys.Down || e.KeyData == Keys.S)
            {
                if (Location.Y + Size.Height < Screen.PrimaryScreen.Bounds.Height)
                    Location = new Point(Location.X, Location.Y + 50);
                else
                    Location = new Point(Location.X, Screen.PrimaryScreen.Bounds.Height - Size.Height);
            }
            else if (e.KeyData == Keys.Right || e.KeyData == Keys.D)
            {
                if (Location.X + Size.Width < Screen.PrimaryScreen.Bounds.Width)
                    Location = new Point(Location.X + 50, Location.Y);
                else
                    Location = new Point(Screen.PrimaryScreen.Bounds.Width - Size.Width, Location.Y);
            }
            else if (e.KeyData == Keys.Left || e.KeyData == Keys.A)
            {
                if (Location.X - 50 > 0)
                    Location = new Point(Location.X - 50, Location.Y);
                else
                    Location = new Point(0, Location.Y);
            }
        }
    }
}
