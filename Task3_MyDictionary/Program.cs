namespace Task3_MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 3
            //Используя Visual Studio, создайте проект по шаблону Console Application. 
            //Создайте класс MyDictionary<TKey, TValue>. Реализуйте в простейшем приближении возможность 
            //использования его экземпляра аналогично экземпляру класса Dictionary (Урок 6 пример 5). 
            //Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод 
            //добавления пар элементов, индексатор для получения значения элемента по указанному индексу и 
            //свойство только для чтения для получения общего количества пар элементов.
            #endregion

            // Instance class myDictionary.
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            // Call method to add into list.
            myDictionary.Add(1, "Hi");

            myDictionary.Add(2, "there");

            myDictionary.Add(3, "!");

            // Show myDictionary elements.
            for (int i = 0; i < myDictionary.Lenght; i++)
            {
                Console.WriteLine("{0} - {1}", myDictionary[i].Key, myDictionary[i].Value);
            }

            // Delay.
            Console.ReadLine();

        }
    }
}

