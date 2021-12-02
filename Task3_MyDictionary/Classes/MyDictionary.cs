class MyDictionary<TKey, TValue>
{// Declare class MyDictionary<TKey, TValue> with various data type of its elements.

    // Private field - List its elements.
    private List<TKey> _keyList;
    private List<TValue> _valueList;

    // Declare constructor class MyList<TKey, TValue>.
    public MyDictionary()
    {
        _keyList = new List<TKey> { };
        _valueList = new List<TValue> { };
    }

    // Declare public attribute of the class - number of elements.
    public long Lenght { get { return _keyList.Count; } }

    // Declare class indexer.
    public (TKey Key, TValue Value) this[int index]
    {
        get
        { return (_keyList[index], _valueList[index]); }

    }

    /// <summary>
    /// Adds new item to MyDictionary.
    /// </summary>
    /// <param name="item"></param>
    public void Add(TKey key, TValue value)
    {
        _keyList.Add(key);
        _valueList.Add(value);
    }
}