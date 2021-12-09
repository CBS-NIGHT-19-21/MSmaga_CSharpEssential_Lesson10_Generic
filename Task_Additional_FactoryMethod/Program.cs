namespace Task_Additional_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание дополнительное
            //Используя Visual Studio, создайте проект по шаблону Console Application. 
            //Создайте класс MyClass<T>, содержащий статический фабричный метод – T FacrotyMethod(),
            //который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места 
            //заполнения типом – Т). 
            #endregion

            // Instance class MyClass using various data type of a formal arg.

            MyClass<int> instance0 = new MyClass<int>(13);

            MyClass<float> instance1 = new MyClass<float>(13);

            MyClass<double> instance2 = new MyClass<double>(13);

            MyClass<string> instance4 = new MyClass<string>("13");

            //Delay
            Console.ReadLine();
        }
    }
}

