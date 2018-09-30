using System;
using System.Linq;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;

namespace CosmosDb.Console
{
    public static class Program
    {
        private const string endpointUri = "[Replace with your EndpointUri]";
        private const string primaryKey = "[Replace with your PrimaryKey]";
        private static DocumentClient client;
        private const string databaseName = "my-database";
        private const string collectionName = "my-collection";

        public static void Main(string[] args)
        {
            client = new DocumentClient(new Uri(endpointUri), primaryKey);

            client.CreateDatabaseIfNotExistsAsync(new Database { Id = databaseName }).Wait();

            client.CreateDocumentCollectionIfNotExistsAsync(UriFactory.CreateDatabaseUri(databaseName), new DocumentCollection { Id = collectionName }).Wait();

            var myDocumentToPersist = new MyDocument
            {
                Id = Guid.NewGuid().ToString(),
                Message = "test"
            };

            client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(databaseName, collectionName), myDocumentToPersist).Wait();

            var readDocumentById = client.ReadDocumentAsync<MyDocument>(UriFactory.CreateDocumentUri(databaseName, collectionName, myDocumentToPersist.Id)).Result;

            var readDocumentsBySearching =
                client.CreateDocumentQuery<MyDocument>(UriFactory.CreateDocumentCollectionUri(databaseName, collectionName))
                      .Where(d => d.Message == myDocumentToPersist.Message)
                      .ToList();
        }
    }

    public class MyDocument
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string Message { get; set; }
    }
}
