
namespace SafarParkApp;

public abstract class Animal
{
    public string Name { get; set; }

    public virtual string Call()
    {
        return "ah";
    }

    public abstract string Move();
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
}

public class Tiger : Lion
{
    public override string Call()
    {
        return "raar";
    }
}
