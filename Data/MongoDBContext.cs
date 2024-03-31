using MongoDB.Driver;

namespace AgendaMongoDB.Data
{
  public class MongoDBContext
  {
    private IMongoDatabase _database;

    public MongoDBContext(string connectionString, string databaseName)
    {
      var client = new MongoClient(connectionString);
      _database = client.GetDatabase(databaseName);
    }

    public IMongoCollection<Models.User> Users => _database.GetCollection<Models.User>("users");
  }
}
