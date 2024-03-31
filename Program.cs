using AgendaMongoDB.Data;
using AgendaMongoDB.Models;
using AgendaMongoDB.Services;

class Program

{
  static async Task Main(string[] args)
  {
    var connectionString = "mongodb://localhost:27017";
    var databaseName = "agenda";

    var dbContext = new MongoDBContext(connectionString, databaseName);
    var agendaService = new AgendaService(dbContext);

    var user = new User
    {
      Name = "Bruno",
      Email = "bruno@email.com",
      Password = "bruno123",
      Contacts =
      [
        new Contact { Name = "Vegeta", Email = "vegeta@email.com", PhoneNumber = "38998898989" },
        new Contact { Name = "Goku", Email = "goku@email.com", PhoneNumber = "31998498989" }
      ]
    };

    await agendaService.CreateUserAsync(user);
  }
}
