using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;

namespace ServiceBus.Subscriber
{
    public class Program
    {
        private static SubscriptionClient subscriptionClient;
        private const string connectionString = "[Replace with your connectionString]";
        private const string topicName = "MyTopic";

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the subscription name:");

            var subscriptionName = Console.ReadLine();

            subscriptionClient = new SubscriptionClient(connectionString, topicName, subscriptionName);

            subscriptionClient.RegisterMessageHandler(
                MessageReceivedHandler,
                new MessageHandlerOptions(async handlerArgs => await Task.Run(() => Console.WriteLine(handlerArgs.Exception)))
                {
                    MaxConcurrentCalls = 1,
                    AutoComplete = false
                });

            Thread.Sleep(Timeout.Infinite);
        }

        private static async Task MessageReceivedHandler(Message message, CancellationToken token)
        {
            var messageBody = Encoding.UTF8.GetString(message.Body);

            Console.WriteLine(messageBody);

            await subscriptionClient.CompleteAsync(message.SystemProperties.LockToken);
        }
    }
}
