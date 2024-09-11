using Microsoft.AspNetCore.Mvc;

public class ClientRepository : IEntityRepository<Client>
{
    public Task<IActionResult> AddAsync(Client entity)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> UpdateAsync(string id)
    {
        throw new NotImplementedException();
    }
}