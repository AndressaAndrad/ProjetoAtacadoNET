namespace Atacado.DAL.Ancestral
{
    public interface IActionDeleteDAO<T>
    {
        T Delete(T entity);

        T Delete(int id);
    }
}
