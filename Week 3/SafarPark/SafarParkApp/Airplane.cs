
namespace VehicleClassApp;

public class Airplane : Vehicle
{
    private string _airline;


    public int Altitude { get; set; } 
    

    public Airplane(int capacity) : base(capacity)
    {

    }

    public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
    {
       _airline = airline;
    }

    public void Ascend(int distance)
    {
        Altitude += distance;    
    }

    public void Descend(int distance)
    {
        Altitude -= distance;
    }

    public override string Move()
    {
        Position += Speed;
        return "Moving along";
    }

    public override string Move(int times)
    {
        Position += Speed * times;
        return "Moving along";
    }

    public override string ToString()
    {
        return $"{base.ToString()}";
    }


}
