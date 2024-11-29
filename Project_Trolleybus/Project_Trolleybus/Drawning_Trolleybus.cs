namespace Project_Trolleybus;

internal class Drawning_Trolleybus
{
    public Entity_Trolleybus? Entity_Trolleybus { get; private set; }

    private int? _pictureWidth;    // Ширина окна

    private int? _pictureHeight;    // Высота окна

    private int? _startPosX;    // Левая координата прорисовки автомобиля

    private int? _startPosY;    // Верхняя кооридната прорисовки автомобиля

    private readonly int _drawningCarWidth = 110;    // Ширина прорисовки автомобиля

    private readonly int _drawningCarHeight = 60;    // Высота прорисовки автомобиля

    /// <param name="speed">Скорость</param>
    /// <param name="weight">Вес</param>
    /// <param name="bodyColor">Основной цвет</param>
    /// <param name="additionalColor">Дополнительный цвет</param>
    /// <param name="bodyKit">Признак наличия обвеса</param>
    /// <param name="horns">Признак наличия рогов</param>
    /// <param name="chandelier">Признак наличия люстры</param>
    /// <param name="bodyGlass">Признак наличия стекол</param>
    public void Init(int speed, double weight, Color bodyColor,
        Color additionalColor, bool bodyKit, bool horns, bool chandelier, bool bodyGlass)
    {
        Entity_Trolleybus = new Entity_Trolleybus();
        Entity_Trolleybus.Init(speed, weight, bodyColor, additionalColor, bodyKit, horns, chandelier, bodyGlass);
        _pictureWidth = null;
        _pictureHeight = null;
        _startPosX = null;
        _startPosY = null;
    }

    /// <param name="width">Ширина поля</param>
    /// <param name="height">Высота поля</param>
    public bool SetPictureSize(int width, int height)
    {
        _pictureWidth = width;
        _pictureHeight = height;
        return true;
    }

    /// <param name="x">Координата X</param>
    /// <param name="y">Координата Y</param>
    public void SetPosition(int x, int y)
    {
        if (!_pictureHeight.HasValue || !_pictureWidth.HasValue)
        {
            return;
        }
        _startPosX = x;
        _startPosY = y;
    }

    public bool MoveTransport(Direction_Type direction)
    {
        if (Entity_Trolleybus == null || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return false;
        }

        switch (direction)
        {
            //влево
            case Direction_Type.Left:
                if (_startPosX.Value - Entity_Trolleybus.Step > 0)
                {
                    _startPosX -= (int)Entity_Trolleybus.Step;
                }
                return true;
            //вверх
            case Direction_Type.Up:
                if (_startPosY.Value - Entity_Trolleybus.Step > 0)
                {
                    _startPosY -= (int)Entity_Trolleybus.Step;
                }
                return true;
            // вправо
            case Direction_Type.Right:
                //TODO прописать логику сдвига в право
                return true;
            //вниз
            case Direction_Type.Down:
                //TODO прописать логику сдвига в вниз
                return true;
            default:
                return false;
        }


    }

    /// <param name="g"></param>
    public void DrawTransport(Graphics g)
    {
        if (Entity_Trolleybus == null || !_startPosX.HasValue || !_startPosY.HasValue)
            return;

        // Основное тело троллейбуса
        g.FillRectangle(new SolidBrush(Entity_Trolleybus.BodyColor), _startPosX.Value, _startPosY.Value, 170, 50);
        g.DrawRectangle(new Pen(Color.Black), _startPosX.Value, _startPosY.Value, 170, 50);

        // Колеса
        g.FillEllipse(new SolidBrush(Color.Black), _startPosX.Value + 20, _startPosY.Value + 45, 20, 20);
        g.FillEllipse(new SolidBrush(Color.Black), _startPosX.Value + 130, _startPosY.Value + 45, 20, 20);

        // Стекла
        Brush brGlass = new SolidBrush(Color.AliceBlue);
        Pen penGlass = new Pen(Color.Black);

        if (Entity_Trolleybus.BodyGlass) // 4 маленьких окна
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
        if (Entity_Trolleybus.Horns)
        {
            Pen penHorns = new Pen(Color.Gray, 2);
            g.DrawLine(penHorns, _startPosX.Value + 80, _startPosY.Value, _startPosX.Value + 60, _startPosY.Value - 30);
            g.DrawLine(penHorns, _startPosX.Value + 90, _startPosY.Value, _startPosX.Value + 110, _startPosY.Value - 30);
        }

        // Порог троллейбуса
        if (Entity_Trolleybus.BodyKit)
        {
            Brush bodyKitBrush = new SolidBrush(Entity_Trolleybus.AdditionalColor);
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
        if (Entity_Trolleybus.Сhandelier)
        {
            g.FillEllipse(brLightF, _startPosX.Value + 50, _startPosY.Value + 40, 10, 10);
            g.FillEllipse(brLightF, _startPosX.Value + 110, _startPosY.Value + 40, 10, 10);
            g.DrawEllipse(penLight, _startPosX.Value + 50, _startPosY.Value + 40, 10, 10);
            g.DrawEllipse(penLight, _startPosX.Value + 110, _startPosY.Value + 40, 10, 10);
        }
    }
}
