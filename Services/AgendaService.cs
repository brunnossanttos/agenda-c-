using System.Threading.Tasks;
using AgendaMongoDB.Data;
using MongoDB.Driver;

namespace AgendaMongoDB.Services
{
  public class AgendaService
  {
    private readonly MongoDBContext _dbContext;

    public AgendaService(MongoDBContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task CreateUserAsync(Models.User user)
    {
      await _dbContext.Users.InsertOneAsync(user);
    }

    // Adicione métodos para outras operações CRUD conforme necessário
  }
}
