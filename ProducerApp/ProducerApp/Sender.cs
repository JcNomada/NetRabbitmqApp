using RabbitMQ.Client;
using System.Text;

namespace ProducerApp
{
    public class Sender
    {
        public async Task SenderMethod()
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            using (var connection = await factory.CreateConnectionAsync())
            using (var channel = await connection.CreateChannelAsync())
            {
                await channel.QueueDeclareAsync("BasicTest", false, false, false, null);
                string message = "Getting started with net core rabbit mq";
                var body = Encoding.UTF8.GetBytes(message);

                await channel.BasicPublishAsync(exchange: string.Empty, routingKey: "hello", body: body);
                Console.WriteLine($" [x] Sent {message}");

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}
