using Project_Trolleybus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Trolleybus.Drawnings;

public class Drawning_Car
{
    public Entity_Car? Entity_Car { get; protected set; }

    private int? _pictureWidth;    // Ширина окна

    private int? _pictureHeight;    // Высота окна

    protected int? _startPosX;     // Левая координата прорисовки автомобиля

    protected int? _startPosY;    // Верхняя кооридната прорисовки автомобиля

    private readonly int _drawningCarWidth = 110;    // Ширина прорисовки автомобиля

    private readonly int _drawningCarHeight = 60;    // Высота прорисовки автомобиля

    public int? GetPosX => _startPosX;    //  Координата X объекта

    public int? GetPosY => _startPosY;    // Координата Y объекта

    public int GetWidth => _drawningCarWidth;    // Ширина объекта

    public int GetHeight => _drawningCarHeight;    // Высота объекта


    /// <summary>
    /// Пустой конструктор
    /// </summary>
    private Drawning_Car()
    {
        _pictureWidth = null;
        _pictureHeight = null;
        _startPosX = null;
        _startPosY = null;
    }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="speed">Скорость</param>
    /// <param name="weight">Вес</param>
    /// <param name="bodyColor">Основной цвет</param>
    public Drawning_Car(int speed, double weight, Color bodyColor) : this()
    {
        Entity_Car = new Entity_Car(speed, weight, bodyColor);
    }

    /// <summary>
    /// Конструктор
    /// </summary>
    protected Drawning_Car(int drawningCarWidth, int drawningCarHeight) : this()
    {
        _drawningCarWidth = drawningCarWidth;
        _drawningCarHeight = drawningCarHeight;
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
        if (Entity_Car == null || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return false;
        }

        switch (direction)
        {
            //влево
            case Direction_Type.Left:
                if (_startPosX.Value - Entity_Car.Step > 0)
                {
                    _startPosX -= (int)Entity_Car.Step;
                }
                return true;
            //вверх
            case Direction_Type.Up:
                if (_startPosY.Value - Entity_Car.Step > 0)
                {
                    _startPosY -= (int)Entity_Car.Step;
                }
                return true;
            // вправо
            case Direction_Type.Right:
                if (_startPosX.Value + _drawningCarWidth + Entity_Car.Step < _pictureWidth)
                    _startPosX += (int)Entity_Car.Step;
                return true;
            //вниз
            case Direction_Type.Down:
                if (_startPosY.Value + _drawningCarHeight + Entity_Car.Step < _pictureHeight)
                    _startPosY += (int)Entity_Car.Step;
                return true;
            default:
                return false;
        }
    }

    /// <param name="g"></param>
    public virtual void DrawTransport(Graphics g)
    {
        if (Entity_Car == null || !_startPosX.HasValue || !_startPosY.HasValue)
            return;

        // Основное тело троллейбуса
        g.FillRectangle(new SolidBrush(Entity_Car.BodyColor), _startPosX.Value, _startPosY.Value, 170, 50);
        g.DrawRectangle(new Pen(Color.Black), _startPosX.Value, _startPosY.Value, 170, 50);

        // Колеса
        g.FillEllipse(new SolidBrush(Color.Black), _startPosX.Value + 20, _startPosY.Value + 45, 20, 20);
        g.FillEllipse(new SolidBrush(Color.Black), _startPosX.Value + 130, _startPosY.Value + 45, 20, 20);

        // Окно с правой стороны
        g.FillRectangle(new SolidBrush(Color.LightBlue), _startPosX.Value + 140, _startPosY.Value + 10, 30, 25);
        g.DrawRectangle(new Pen(Color.Black), _startPosX.Value + 140, _startPosY.Value + 10, 30, 25);
    }
}
