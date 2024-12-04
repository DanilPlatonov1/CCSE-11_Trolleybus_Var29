namespace Project_Trolleybus.Entities;

public class Entity_Car
{
    public int Speed { get; private set; }

    public double Weight { get; private set; }

    public Color BodyColor { get; private set; }

    public double Step => Speed * 100 / Weight;

    /// <param name="speed">Скорость</param>
    /// <param name="weight">Вес автомобиля</param>
    /// <param name="bodyColor">Основной цвет</param>
    public Entity_Car(int speed, double weight, Color bodyColor)
    {
        Speed = speed;
        Weight = weight;
        BodyColor = bodyColor;
    }
}
