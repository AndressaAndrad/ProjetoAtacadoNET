

namespace Atacado.DAL.Ancestral
{
    public interface IActionCreateDAO<T>
    {
        T Create(T entity);
    }
}
