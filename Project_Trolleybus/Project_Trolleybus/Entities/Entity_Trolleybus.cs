namespace Project_Trolleybus.Entities;

public class Entity_Trolleybus : Entity_Car
{
    public Color AdditionalColor { get; private set; }

    public bool BodyKit { get; private set; }

    public bool Horns { get; private set; }

    public bool Сhandelier { get; private set; }

    public bool BodyGlass { get; private set; }

    /// <param name="additionalColor">Дополнительный цвет</param>
    /// <param name="bodyKit">Признак наличия обвеса</param>
    /// <param name="horns">Признак наличия рогов</param>
    /// <param name="chandelier">Признак наличия люстры</param>
    /// <param name="bodyGlass">Признак наличия стекол</param>
    public Entity_Trolleybus(int speed, double weight, Color bodyColor,
        Color additionalColor, bool bodyKit, bool horns, bool chandelier, bool bodyGlass)  : base (speed, weight ,bodyColor)
    {
        AdditionalColor = additionalColor;
        BodyKit = bodyKit;
        Horns = horns;
        Сhandelier = chandelier;
        BodyGlass = bodyGlass;
    }

    public Entity_Trolleybus(int speed, double weigth, Color bodyColor) : base(speed, weigth, bodyColor) { }
}
