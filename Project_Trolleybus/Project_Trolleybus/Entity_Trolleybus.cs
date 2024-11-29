namespace Project_Trolleybus;

public class Entity_Trolleybus
{
    public int Speed { get; private set; }

    public double Weight { get; private set; }

    public Color BodyColor { get; private set; }

    public Color AdditionalColor { get; private set; }

    public bool BodyKit { get; private set; }

    public bool Horns { get; private set; }

    public bool Сhandelier { get; private set; }

    public bool BodyGlass { get; private set; }

    public double Step => Speed * 100 / Weight;
    /// <param name="speed">Скорость</param>
    /// <param name="weight">Вес автомобиля</param>
    /// <param name="bodyColor">Основной цвет</param>
    /// <param name="additionalColor">Дополнительный цвет</param>
    /// <param name="bodyKit">Признак наличия обвеса</param>
    /// <param name="horns">Признак наличия рогов</param>
    /// <param name="chandelier">Признак наличия люстры</param>
    /// <param name="bodyGlass">Признак наличия стекол</param>
    public void Init(int speed, double weight, Color bodyColor,
        Color additionalColor, bool bodyKit, bool horns, bool chandelier, bool bodyGlass)
    {
        Speed = speed;
        Weight = weight;
        BodyColor = bodyColor;
        AdditionalColor = additionalColor;
        BodyKit = bodyKit;
        Horns = horns;
        Сhandelier = chandelier;
        BodyGlass = bodyGlass;
    }
}
