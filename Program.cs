namespace JetCode;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        var person = new Person("Rochinel", (22));
        
        Console.WriteLine($"my name is {person.Name} and i'm {person.Age} years old");
    }
}