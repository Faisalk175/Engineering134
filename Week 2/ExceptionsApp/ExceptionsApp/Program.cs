using System.IO;
namespace ExceptionsApp;

public class Program
{
    static void Main(string[] args)
    {
        string textfile;
        try
        {
            textfile = File.ReadAllText("SuperSecretDiary.txt");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("Sorry, I cant find the file :(");
            Console.WriteLine(e.Message);
        }
        catch (NotImplementedException e)
        {
            Console.WriteLine("Write the method");
        }
        catch
        {
            Console.WriteLine("There was a problem");
        }
        finally
        {
            Console.WriteLine("I am always run");
        }
        try
        {
            Console.WriteLine("Alex's grade was " + Grade(81));
            Console.WriteLine("Jasser grade was " + Grade(-75));
        } catch
        {
            Console.WriteLine("There was a problem");
        }
        
    }
    public static string Grade(int mark)
    {
      if (mark < 1 || mark > 100)
      {
            throw new ArgumentOutOfRangeException("Mark cannot be out the range 1 to 100");
      }

        return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
    }
    

}







