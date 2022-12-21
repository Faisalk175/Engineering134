using SafarParkApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleClassApp;

public abstract class Vehicle : IMoveable, IEquatable<Vehicle?>
{
    private int _capacity;
    private int _numPassengers;
    


    public int Position { get; set; }
    public int Speed { get; init; }
    public int NumPassengers
    {
        get
        {
            return _numPassengers;

        }
        set
        {
            if (value >= 0 && value <= _capacity) _numPassengers = value;
        }
    }


    public virtual string Move()
    {
        Position += Speed;
        return "Moving along";
    }

    public virtual string Move(int times)
    {
        Position += times * Speed;
        return $"Moving along {times} times";
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Vehicle);
    }

    public bool Equals(Vehicle? other)
    {
        return other is not null &&
               _capacity == other._capacity &&
               Speed == other.Speed;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_capacity, Speed);
    }

    public Vehicle()
    {
        Speed = 10;
    }

    public Vehicle(int capacity, int speed = 10)
    {
        _capacity = capacity;
        Speed = speed;
    }

    public static bool operator ==(Vehicle? left, Vehicle? right)
    {
        return EqualityComparer<Vehicle>.Default.Equals(left, right);
    }

    public static bool operator !=(Vehicle? left, Vehicle? right)
    {
        return !(left == right);
    }

    //public override string ToString()
    //{
    //    return base.ToString() + " " + 
    //}



}