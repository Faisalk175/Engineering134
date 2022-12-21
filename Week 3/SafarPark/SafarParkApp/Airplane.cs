
using System.ComponentModel.DataAnnotations;
using System.Windows.Markup;

namespace VehicleClassApp;

public class Airplane : Vehicle, IEquatable<Airplane?>, IComparable<Airplane>
{
    private string _airline;
    private int _altitude;

    public int Altitude
    {
        get
        {
            return _altitude;
        }


        set
        {
            if (value >= 0) { _altitude = value; }
            else
            {
                throw new ArgumentException("Altitude cant be less than zero");
            }
        }
    }    
    

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

    public override bool Equals(object? obj)
    {
        return Equals(obj as Airplane);
    }

    public bool Equals(Airplane? other)
    {
        return other is not null &&
        NumPassengers == other.NumPassengers;
        base.Equals(other);
    }


    public override int GetHashCode()
    {
        return HashCode.Combine(Speed, NumPassengers);
    }

    public int CompareTo(Airplane? other)
    {
        // retutn < 0 if ALtitude > other.Altitude
        // return 0 if equal
        // return > 0 if Altitude < other.Altitude
        if (Altitude > other.Altitude)
        {
            return 1;
        }
        else if (Altitude == other.Altitude)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }

    public static bool operator == (Airplane left, Airplane right)
    {
        return EqualityComparer<Airplane>.Default.Equals(left, right);
    }

    public static bool operator != (Airplane left, Airplane right)
    {
        return !(left == right);
    }
}
