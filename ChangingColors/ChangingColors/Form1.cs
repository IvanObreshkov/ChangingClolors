using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChangingColors
{
    public partial class Form1 : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int a = 256, freq = 10;
            Random c = new Random();
            for (int i = 0; i <= 40; i++)
            {
                g.Clear(Color.FromArgb(c.Next() % a, c.Next() % a, c.Next() % a));
                System.Threading.Thread.Sleep(1000);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
