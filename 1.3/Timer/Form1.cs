using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        private delegate void DoSmthDelegate(Form1 form1);

        private readonly Timer _timer;
        private readonly DoSmthDelegate _addControl;
        private readonly DoSmthDelegate _delControl;

        public Form1()
        {
            InitializeComponent();
            this.Width = 1300;
            this.Height = 740;
            _timer = new Timer(50, timer1);
            _addControl = _timer.CreateButton;
            _delControl = _timer.ButtonsDelete;
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            _addControl(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
            else
                timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _delControl(this);
        }
    }
}