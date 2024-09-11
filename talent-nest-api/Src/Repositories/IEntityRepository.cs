using Microsoft.AspNetCore.Mvc;

public interface IEntityRepository<T>
{
    Task<IActionResult> GetByIdAsync(string id);
    Task<IActionResult> AddAsync(T entity);
    Task<IActionResult> UpdateAsync(string id);
    Task<IActionResult> DeleteAsync(string id);
    Task<IActionResult> GetAllAsync();
}