
// Declare class MyList<T> with various data type of its elements.
class MyList<T>
{
    // Private field - List its elements.
    private List<T> _list;

    // Declare constructor class MyList<T>.
    public MyList()
    {
        _list = new List<T> { };
    }

    // Declare public attribute of the class - number of elements.
    public long Lenght { get { return _list.Count; } }

    // Declare class indexer.
    public T this[int index]
    {
        get
        { return _list[index]; }
        set
        { _list[index] = value; }
    }

    /// <summary>
    /// Adds new item to MyList.
    /// </summary>
    /// <param name="item"></param>
    public void Add(T item)
    {
        _list.Add(item);
    }

    /// <summary>
    /// Shows List Statistic.
    /// </summary>
    public void ShowStatistic()
    {
        for (int i = 0; i < _list.Count; i++)
        {
            Console.WriteLine($"Element {i} = {_list[i]}");
        }

        Console.WriteLine($"Type of elements = {_list}\nTotal number of elements = {_list.Count}");
    }
}