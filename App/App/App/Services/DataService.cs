using App.Context;
using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Services
{
    public class DataService : IDataService
    {
        private readonly StoreDbContext _dbContext;

        public DataService(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateOrder(int clientId, DateTime createdAt, DateTime? fulfilledAt)
        {
            var createdStatus = await _dbContext.Statuses.SingleAsync(s => s.Name == "Created");

            _dbContext.Orders.Add(new Order { ClientId = clientId, CreatedAt = createdAt, Status = createdStatus, UpdatedAt = fulfilledAt });
            await _dbContext.SaveChangesAsync();
        }

        public Task<Client?> GetClient(int clientId)
        {
            return _dbContext.Clients
                .Where(x => x.Id == clientId)
                .Include(x => x.Orders)
                    .ThenInclude(x => x.Status)
                .Include(x => x.Orders)
                    .ThenInclude(x => x.ProductOrders)
                        .ThenInclude(x => x.Product)
                .SingleOrDefaultAsync();
        }

        public Task<List<Status>> GetStatuses()
        {
            return _dbContext.Statuses.ToListAsync();
        }
    }
}
