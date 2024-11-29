using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Trolleybus
{
    public partial class Form_Trolleybus : Form
    {
        private Drawning_Trolleybus? _drawning_Trolleybus;

        public Form_Trolleybus()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            if (_drawning_Trolleybus == null)
            {
                return;
            }

            Bitmap bmp = new(pictureBoxTrolleybus.Width, pictureBoxTrolleybus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _drawning_Trolleybus.DrawTransport(gr);
            pictureBoxTrolleybus.Image = bmp;
        }


        private void ButtonCreateTrolleybus_Click(object sender, EventArgs e)
        {
            Random random = new();
            _drawning_Trolleybus = new Drawning_Trolleybus();
            _drawning_Trolleybus.Init(random.Next(100, 300), random.Next(1000, 3000),
            Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
            Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
            Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)),
            Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)));
            _drawning_Trolleybus.SetPictureSize(pictureBoxTrolleybus.Width, pictureBoxTrolleybus.Height);
            _drawning_Trolleybus.SetPosition(random.Next(10, 100), random.Next(10, 100));

            Draw();

        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (_drawning_Trolleybus == null)
            {
                return;
            }

            string name = ((Button)sender)?.Name ?? string.Empty;
            bool result = false;
            switch (name)
            {
                case "buttonUp":
                    result = _drawning_Trolleybus.MoveTransport(Direction_Type.Up);
                    break;
                case "buttonDown":
                    result = _drawning_Trolleybus.MoveTransport(Direction_Type.Down);
                    break;
                case "buttonLeft":
                    result = _drawning_Trolleybus.MoveTransport(Direction_Type.Left);
                    break;
                case "buttonRight":
                    result = _drawning_Trolleybus.MoveTransport(Direction_Type.Right);
                    break;
            }

            if (result)
            {
                Draw();
            }
        }
    }
}
