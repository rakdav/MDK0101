List<int> list1 = new List<int>();
//добавление
list1.Add(5);
list1.Add(3);
list1.Add(2);
List<int> list2 = new List<int>();
list2.AddRange(list1);
//вывод коллекий
for (int i = 0; i < list1.Count; i++)
{
    Console.Write(list1[i]+" ");
}
Console.WriteLine();
foreach (int item in list1)
{
    Console.Write(item+" ");
}
Console.WriteLine();
//вставка
list1.Insert(1, 8);
foreach (int item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine();
//удаление
list1.Remove(8);
list1.RemoveAt(0);
foreach (int item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine();
list2.Clear();
//размеры
Console.WriteLine(list1.Count);
Console.WriteLine(list1.Capacity);
//сортировка
list1.Sort();
foreach (int item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine();
list1.Reverse();//зеркальное отображение
foreach (int item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine();
//преобразование в массив
int[] mas = list1.ToArray();
foreach (int item in mas)
{
    Console.Write(item + " ");
}
Console.WriteLine();
//поиск
Console.WriteLine(list1.Contains(5));
Console.WriteLine(list1.IndexOf(5));
Console.WriteLine(list1.LastIndexOf(2));

