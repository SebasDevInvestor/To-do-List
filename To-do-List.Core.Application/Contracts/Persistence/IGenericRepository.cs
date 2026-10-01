namespace To_do_List.Core.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : class 
{
    Task<List<T>> GetAllAsync(); //trae to
    
    Task<T?> GetByIdAsync(Guid id); // trae por id 
    
    Task<T>CreateAsync(T entity); // crea las entidaddes
    
    Task<T> UpdateAsync(T entity); //Modifica las entidades
    
    Task DeleteAsync(T entity); //Elimina las entidades
}