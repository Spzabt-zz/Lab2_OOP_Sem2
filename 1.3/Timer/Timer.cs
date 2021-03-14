using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Timer
{
    class Timer
    {
        private readonly Random _random = new Random();
        private readonly List<Button> _buttons = new List<Button>();
        private Color _color;

        public Timer(int milSec, System.Timers.Timer timer)
        {
            timer.Interval = milSec;
        }

        public void CreateButton(Form1 form1)
        {
            Button button = new Button();
            button.Location = new Point(_random.Next(1200), _random.Next(670));
            button.Size = new Size(_random.Next(75, 150), _random.Next(23, 46));
            _color = Color.FromArgb(_random.Next(255), _random.Next(255),
                _random.Next(255));
            button.Text = string.Empty;
            button.BackColor = _color;
            _buttons.Add(button);
            form1.Controls.Add(button);
        }

        public void ButtonsDelete(Form1 form1)
        {
            foreach (var button in _buttons)
            {
                form1.Controls.Remove(button);
            }
        }
    }
}