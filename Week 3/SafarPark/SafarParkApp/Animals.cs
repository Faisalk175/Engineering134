
namespace SafarParkApp;

public abstract class Animal : IMoveable

{ 
    public string Name { get; set; }

    public virtual string Call()
    {
        return "ah";
    }

    public abstract string Move();
    public abstract string Move(int times);



}

public class Cat : Animal
{
    public override string Call()
    {
        return "Meow";
    }


    public override string Move()
    {
        return "saunters";
    }

    public override string Move(int times)
    {
        return Move() + $" {times} times";
    }

   

}


public class Lion : Animal
{
    public override string Call()
    {
        return "Roaar";
    }

    public override string Move()
    {
        return "Walks";
    }

    public override string Move(int times)
    {
        return Move() + $" {times} times";
    }

   
}

public class Tiger : Lion
{
    public override string Call()
    {
        return "raar";
    }
}
