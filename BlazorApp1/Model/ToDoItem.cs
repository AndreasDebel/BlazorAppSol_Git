namespace BlazorApp1.Model;

public class ToDoItem : IComparable<ToDoItem>
{
    public string Title { get; set; } = "";
    public bool IsDone { get; set; }

    public int CompareTo(ToDoItem? other)
    {

        if (other == null) return 1;


        if(this.IsDone == other.IsDone) return 0;
        return this.IsDone ? 1 : -1;
    }
}