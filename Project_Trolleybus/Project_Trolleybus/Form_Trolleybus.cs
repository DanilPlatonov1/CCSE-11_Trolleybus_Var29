using Project_Trolleybus.Drawnings;
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
        private Drawning_Car? _drawning_Car;

        public Form_Trolleybus()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            if (_drawning_Car == null)
            {
                return;
            }

            Bitmap bmp = new(pictureBoxTrolleybus.Width, pictureBoxTrolleybus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _drawning_Car.DrawTransport(gr);
            pictureBoxTrolleybus.Image = bmp;
        }

        private void CreateObject(string type)
        {
            Random random = new ();
            switch (type)
            {
                case nameof(Drawning_Car):
                    _drawning_Car = new Drawning_Car(random.Next(100, 300), random.Next(1000, 3000),
                        Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)));
                    break;
                case nameof(Drawning_Trolleybus):
                    _drawning_Car = new Drawning_Trolleybus(random.Next(100, 300), random.Next(1000, 3000),
                        Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                        Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                        Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)),
                        Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)));
                    break;
                default:
                    return;
            }

            _drawning_Car.SetPictureSize(pictureBoxTrolleybus.Width, pictureBoxTrolleybus.Height);
            _drawning_Car.SetPosition(random.Next(10, 100), random.Next(10, 100));
            Draw();
        }


        private void ButtonCreateTrolleybus_Click(object sender, EventArgs e)
        {
            CreateObject(nameof(Drawning_Trolleybus));
        }

        private void ButtonCreateCar_Click(object sender, EventArgs e)
        {
            CreateObject(nameof(Drawning_Car));
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (_drawning_Car == null)
            {
                return;
            }

            string name = ((Button)sender)?.Name ?? string.Empty;
            bool result = false;
            switch (name)
            {
                case "buttonUp":
                    result = _drawning_Car.MoveTransport(Direction_Type.Up);
                    break;
                case "buttonDown":
                    result = _drawning_Car.MoveTransport(Direction_Type.Down);
                    break;
                case "buttonLeft":
                    result = _drawning_Car.MoveTransport(Direction_Type.Left);
                    break;
                case "buttonRight":
                    result = _drawning_Car.MoveTransport(Direction_Type.Right);
                    break;
            }

            if (result)
            {
                Draw();
            }
        }
    }
}
