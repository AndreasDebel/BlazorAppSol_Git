using BlazorApp1.Model;

namespace BlazorApp1_nyAPI.Repositories
{
    public class ToDoRepositoryInMemory : IToDoRepository
    {
        private List<ToDoItem> _items = new();

        public List<ToDoItem> GetAll() => _items;

        public void Add(ToDoItem item)
        {
            item.Id = _items.Count + 1; 
            _items.Add(item);
        }

        public void Delete(ToDoItem item)
        {
            _items.RemoveAll(x => x.Id == item.Id);
        }

        public void Update(ToDoItem item)
        {
            Delete(item);
            _items.Add(item);
        }
    }
}
