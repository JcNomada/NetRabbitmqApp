using ProducerApp;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hola");
        var sender = new Sender();
        sender.SenderMethod().Wait();
    }
}