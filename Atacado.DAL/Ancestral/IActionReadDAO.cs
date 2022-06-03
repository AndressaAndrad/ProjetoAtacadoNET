namespace Atacado.DAL.Ancestral
{
    public interface IActionReadDAO<T>
    {
        T Read(int id);

        List<T> ReadAll();
    }
}
