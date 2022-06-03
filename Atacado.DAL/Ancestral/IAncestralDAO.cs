namespace Atacado.DAL.Ancestral
{
    public interface IAncestralDAO<T> : 
        IActionCreateDAO<T> , 
        IActionReadDAO<T>, 
        IActionUpdateDAO<T>, 
        IActionDeleteDAO<T>

    {
    }
}
