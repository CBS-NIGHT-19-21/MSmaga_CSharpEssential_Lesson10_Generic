public class MyClass<Type>
{
    // Field of the instance of the class with various data type.
    private readonly Type _field;

    // Public attibute of instance with various data type.
    public Type Field { get { return _field; } }

    // The class constractor with various data type.
    public MyClass(Type field)
    {
        _field = field;
        Console.WriteLine($"{Field} - {this.GetType()}");
    }
}