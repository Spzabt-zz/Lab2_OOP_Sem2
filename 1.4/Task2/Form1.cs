using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        private delegate void FormDelegate();

        private bool _isOpacitySwitched = true;
        private bool _isBackColorSwitched = true;
        private readonly Color _defaultColor = DefaultBackColor;

        private readonly FormDelegate _helloDelegate;
        private readonly FormDelegate _switchOpacityDelegate;
        private readonly FormDelegate _switchBackColorDelegate;
        private FormDelegate _emptyFormDelegate;

        public Form1()
        {
            InitializeComponent();
            _helloDelegate = () => { MessageBox.Show("Hello world!"); };
            _switchOpacityDelegate = () =>
            {
                Opacity = _isOpacitySwitched ? 0.60 : 1;
                _isOpacitySwitched = !_isOpacitySwitched;
            };
            _switchBackColorDelegate = () =>
            {
                BackColor = _isBackColorSwitched ? Color.Red : _defaultColor;
                _isBackColorSwitched = !_isBackColorSwitched;
            };
        }

        private void CheckStateMethod()
        {
            if (checkBox1.Checked)
                _switchOpacityDelegate();
            if (checkBox2.Checked)
                _switchBackColorDelegate();
            if (checkBox3.Checked)
                _helloDelegate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _switchOpacityDelegate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _switchBackColorDelegate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _helloDelegate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Super button!");
            _emptyFormDelegate = CheckStateMethod;
            _emptyFormDelegate();
        }
    }
}