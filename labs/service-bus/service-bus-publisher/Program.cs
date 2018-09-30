using System;
using System.Text;
using Microsoft.Azure.ServiceBus;

namespace ServiceBus.Publisher
{
    public class Program
    {
        private const string connectionString = "Endpoint=sb://robnamespace2.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=usByg0LJsnkuZhRCCucFsy7EyOMv1XrSaLFlYUvQ5DM=";
        private const string topicName = "MyTopic";

        public static void Main(string[] args)
        {
            var client = new TopicClient(connectionString, topicName);

            while (true)
            {
                Console.WriteLine("Enter your message:");

                var message = Console.ReadLine();

                client.SendAsync(new Message(Encoding.UTF8.GetBytes(message))).Wait();
            }
        }
    }
}
