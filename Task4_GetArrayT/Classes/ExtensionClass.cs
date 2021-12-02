static class ExtensionClass
{   // Declare extension method for MyList.
    public static Type[] GetArray<Type>(this MyList<Type> list)
    {
        Type[] array = new Type[list.Lenght];
        for (int i = 0; i < list.Lenght; i++)
        {
            array[i] = list[i];
        }
        return array;
    }
}