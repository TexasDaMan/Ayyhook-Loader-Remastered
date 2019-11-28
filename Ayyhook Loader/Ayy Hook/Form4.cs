using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Ayy_Hook
{
    public partial class Form4 : MetroForm
    {
        public static byte[] dll;
        public static string Process;
        public static bool download;
        public static string url;
        public static string status;
        public static int value = 1;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.TopMost = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.TopMost = true;
            metroLabel1.Text = status;
            metroProgressBar1.Value = value;
        }
    }
}
