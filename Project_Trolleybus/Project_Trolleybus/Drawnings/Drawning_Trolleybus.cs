using Project_Trolleybus.Entities;

namespace Project_Trolleybus.Drawnings;

public class Drawning_Trolleybus : Drawning_Car
{
    /// <param name="speed">Скорость</param>
    /// <param name="weight">Вес</param>
    /// <param name="bodyColor">Основной цвет</param>
    /// <param name="additionalColor">Дополнительный цвет</param>
    /// <param name="bodyKit">Признак наличия обвеса</param>
    /// <param name="horns">Признак наличия рогов</param>
    /// <param name="chandelier">Признак наличия люстры</param>
    /// <param name="bodyGlass">Признак наличия стекол</param>
    public Drawning_Trolleybus(int speed, double weight, Color bodyColor,
        Color additionalColor, bool bodyKit, bool horns, bool chandelier, bool bodyGlass) : base(110, 60)
    {
        Entity_Car = new Entity_Trolleybus(speed, weight, bodyColor, additionalColor, bodyKit, horns, chandelier, bodyGlass);
    }

    public Drawning_Trolleybus(int speed, double weight, Color bodyColor) : base(110, 60)
    {
        Entity_Car = new Entity_Trolleybus(speed, weight, bodyColor);
    }

    public override void DrawTransport(Graphics g)
    {
        if (Entity_Car == null || Entity_Car is not Entity_Trolleybus trolleyBus || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return;
        }

        base.DrawTransport(g);

        // Стекла
        Brush brGlass = new SolidBrush(Color.AliceBlue);
        Pen penGlass = new Pen(Color.Black);

        if (trolleyBus.BodyGlass) // 4 маленьких окна
        {
            int windowWidth = 30;
            int windowHeight = 25;
            int gap = 10;
            for (int i = 0; i < 4; i++)
            {
                int x = _startPosX.Value + 10 + i * (windowWidth + gap);
                int y = _startPosY.Value + 10;
                g.FillRectangle(brGlass, x, y, windowWidth, windowHeight);
                g.DrawRectangle(penGlass, x, y, windowWidth, windowHeight);
            }
        }
        else // 3 больших окна
        {
            int windowWidth = 40;
            int windowHeight = 25;
            int gap = 15;
            for (int i = 0; i < 3; i++)
            {
                int x = _startPosX.Value + 10 + i * (windowWidth + gap);
                int y = _startPosY.Value + 10;
                g.FillRectangle(brGlass, x, y, windowWidth, windowHeight);
                g.DrawRectangle(penGlass, x, y, windowWidth, windowHeight);
            }
        }

        // Рога троллейбуса
        if (trolleyBus.Horns)
        {
            Pen penHorns = new Pen(Color.Gray, 2);
            g.DrawLine(penHorns, _startPosX.Value + 80, _startPosY.Value, _startPosX.Value + 60, _startPosY.Value - 30);
            g.DrawLine(penHorns, _startPosX.Value + 90, _startPosY.Value, _startPosX.Value + 110, _startPosY.Value - 30);
        }
        else
        {
            Pen penHorns = new Pen(Color.Black, 2);
            g.DrawLine(penHorns, _startPosX.Value + 80, _startPosY.Value, _startPosX.Value + 60, _startPosY.Value - 30);
            g.DrawLine(penHorns, _startPosX.Value + 90, _startPosY.Value, _startPosX.Value + 110, _startPosY.Value - 30);
        }

        // Порог троллейбуса
        if (trolleyBus.BodyKit)
        {
            Brush bodyKitBrush = new SolidBrush(trolleyBus.AdditionalColor);
            g.FillRectangle(bodyKitBrush, _startPosX.Value, _startPosY.Value + 40, 170, 10);
            g.DrawRectangle(new Pen(Color.Black), _startPosX.Value, _startPosY.Value + 40, 170, 10);
        }

        // Фары
        Brush brLightB = new SolidBrush(Color.Red);
        g.FillEllipse(brLightB, _startPosX.Value, _startPosY.Value + 40, 10, 10);
        Brush brLightF = new SolidBrush(Color.Yellow);
        g.FillEllipse(brLightF, _startPosX.Value + 160, _startPosY.Value + 40, 10, 10);
        Pen penLight = new Pen(Color.Black);
        g.DrawEllipse(penLight, _startPosX.Value, _startPosY.Value + 40, 10, 10);
        g.DrawEllipse(penLight, _startPosX.Value + 160, _startPosY.Value + 40, 10, 10);

        // Дополнительные фары
        if (trolleyBus.Сhandelier)
        {
            g.FillEllipse(brLightF, _startPosX.Value + 50, _startPosY.Value + 40, 10, 10);
            g.FillEllipse(brLightF, _startPosX.Value + 110, _startPosY.Value + 40, 10, 10);
            g.DrawEllipse(penLight, _startPosX.Value + 50, _startPosY.Value + 40, 10, 10);
            g.DrawEllipse(penLight, _startPosX.Value + 110, _startPosY.Value + 40, 10, 10);
        }
    }
}
