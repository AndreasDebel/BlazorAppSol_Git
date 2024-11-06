using BlazorApp1.Model;

namespace BlazorApp1_nyAPI.Repositories
{
    public interface IToDoRepository
    {
        List<ToDoItem> GetAll();
        void Add(ToDoItem item);
        void Delete(ToDoItem item);
        void Update(ToDoItem item);
    }
}
