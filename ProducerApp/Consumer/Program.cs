using ProducerApp;
using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hola");
        var receiver = new Receiver();
        receiver.ProducerMethod().Wait();
    }
}
