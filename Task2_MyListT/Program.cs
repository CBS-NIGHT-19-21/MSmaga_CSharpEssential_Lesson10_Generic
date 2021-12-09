namespace Task2_MyListT
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 2
            //Используя Visual Studio, создайте проект по шаблону Console Application. 
            //Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его 
            //экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс 
            //взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для 
            //получения значения элемента по указанному индексу и свойство только для чтения для получения 
            //общего количества элементов. 
            #endregion

            // Instance class MyList.
            MyList<double> myList = new MyList<double> { };

            // Call class method to add new item.
            myList.Add(13);
            myList.Add(19);
            myList.Add(139);

            // Call class method to show myList statistic.
            myList.ShowStatistic();

            // Delay.
            Console.ReadLine();
        }
    }
}


