namespace Yogurt.Infraestructure.Interfaces.BaseInterface
{
    public interface IRepositoryAsync<T>
    {
        Task Insert(T entity);

        Task<T?> GetById(Guid id);

        Task RemoveByEntity(T entity);
    }
}
