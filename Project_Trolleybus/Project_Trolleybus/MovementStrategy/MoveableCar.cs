using Project_Trolleybus.Drawnings;
using Project_Trolleybus.MovementStrategy;
namespace ProjectSportCar.MovementStrategy;

public class MoveableCar : IMoveableObject
{
    /// <summary>
    /// Поле-объект класса DrawningCar или его наследника
    /// </summary>
    private readonly Drawning_Car? _car = null;
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="car">Объект класса DrawningCar</param>
    public MoveableCar(Drawning_Car car)
    {
        _car = car;
    }
    public ObjectParameters? GetObjectPosition
    {
        get
        {
            if (_car == null || _car.Entity_Car == null || !_car.GetPosX.HasValue || !_car.GetPosY.HasValue)
            {
                return null;
            }
            return new ObjectParameters(_car.GetPosX.Value, _car.GetPosY.Value, _car.GetWidth, _car.GetHeight);
        }
    }

    public int GetStep => (int)(_car?.Entity_Car?.Step ?? 0);

    public bool TryMoveObject(MovementDirection direction)
    {
        if (_car == null || _car.Entity_Car == null)
        {
            return false;
        }
        return _car.MoveTransport(GetDirectionType(direction));
    }

    /// <summary>
    /// Конвертация из MovementDirection в DirectionType
    /// </summary>
    /// <param name="direction">MovementDirection</param>
    /// <returns>DirectionType</returns>
    private static Direction_Type GetDirectionType(MovementDirection direction)
    {
        return direction switch
        {
            MovementDirection.Left => Direction_Type.Left,
            MovementDirection.Right => Direction_Type.Right,
            MovementDirection.Up => Direction_Type.Up,
            MovementDirection.Down => Direction_Type.Down,
            _ => Direction_Type.Unknow,
        };
    }
}