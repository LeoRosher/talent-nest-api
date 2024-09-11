using Microsoft.AspNetCore.Mvc;

public class ProjectRepository : IEntityRepository<Project>
{
    public Task<IActionResult> AddAsync(Project entity)
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