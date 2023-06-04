using App.Models;

namespace App.Services
{
    public interface IDataService
    {
        Task CreateOrder(int clientId, DateTime createdAt, DateTime? fulfilledAt);
        Task<Client?> GetClient(int clientId);
        Task<List<Status>> GetStatuses();
    }
}
