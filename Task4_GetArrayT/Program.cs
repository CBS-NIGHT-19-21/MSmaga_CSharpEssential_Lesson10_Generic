#region Задание 4
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
//Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 
//для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий 
//метод GetArray().
#endregion

// Instance class MyList.
MyList<double> myList = new MyList<double> { };

// Call class method to add new item.
myList.Add(13);
myList.Add(19);
myList.Add(139);

// Call class method to show myList statistic.
myList.ShowStatistic();

// Call extension method to get data for List into Array. 
double[] array = myList.GetArray();

// Show elements of the Array. 
Console.Write("\nFrom array = ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");
}

// Delay.
Console.ReadLine();
