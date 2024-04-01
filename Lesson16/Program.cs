//Коллекция Dictonary<K,V> - словарь

//Dictionary<int, string> people1 = new Dictionary<int, string>();
//var people2 = new Dictionary<int, string>()
//{
//    {5,"Sam"},
//    {10,"Tom"},
//    {17,"Bob"}
//   // {5,"John"}
//};

//foreach(var person in people2)
//{
//    Console.WriteLine($"key:{person.Key} value:{person.Value}");
//}

//var mike = new KeyValuePair<int, string>(34,"Mike");
//var list = new List<KeyValuePair<int, string>>() { mike };
//var peoples = new Dictionary<int, string>(list)
//{
//    [5]="Jerry",
//    [9]="Tom"
//};
//foreach (var person in people2)
//{
//    Console.WriteLine($"key:{person.Key} value:{person.Value}");
//}

//Console.WriteLine(people2[5]);
////Методы и свойства
//Dictionary<string, string> phoneBook = new Dictionary<string, string>();
//phoneBook.Add("+79863456345","Vasya");
//Console.WriteLine(phoneBook.ContainsKey("+79863456345"));
//Console.WriteLine(phoneBook.ContainsValue("Vasya"));
//people2.Remove(10);

////HashSet
//string str = "hello";
//Console.WriteLine(str.GetHashCode());
//HashSet<string> country = new HashSet<string>();
//country.Add("Germany");
//country.Add("Spain");
//country.Add("Italy");
//country.Add("Spain");
//country.Add("Portugal");
//foreach (var item in country)
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();
//SortedSet<string> sortedSet = new SortedSet<string>();
//sortedSet.Add("Germany");
//sortedSet.Add("Spain");
//sortedSet.Add("Italy");
//sortedSet.Add("Spain");
//sortedSet.Add("Sweden");
//foreach (var item in sortedSet)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();
////sortedSet.UnionWith(country);
//sortedSet.Overlaps(country);
//foreach (var item in sortedSet)
//{
//    Console.Write(item + " ");
//}

//ObervableCollection 
using System.Collections.ObjectModel;
using System.Collections.Specialized;

var people = new ObservableCollection<Person>()
{
    new Person("Tom"),
    new Person("Jerry")
};
people.CollectionChanged += People_Collection_Changed;
people.Add(new Person("Tom"));
people.RemoveAt(1);
people[1] = new Person("Bob");
void People_Collection_Changed(object? sender,NotifyCollectionChangedEventArgs e )
{
    switch (e.Action)
    {
        case NotifyCollectionChangedAction.Add:
            if(e.NewItems?[0] is Person newPerson)
            {
                Console.WriteLine($"Добавлен новый объект {newPerson.Name}");
            }
            break;
        case NotifyCollectionChangedAction.Remove:
            if (e.OldItems?[0] is Person oldPerson)
            {
                Console.WriteLine($"Удален объект {oldPerson.Name}");
            }
            break;
        case NotifyCollectionChangedAction.Replace:
            if (e.NewItems?[0] is Person replacingPerson&&
                e.OldItems?[0] is Person replacedPerson)
            {
                Console.WriteLine($"Объект {replacedPerson.Name} заменен на {replacingPerson.Name}");
            }
            break;
    }
}

class Person
{
    public Person (string name)
    {
        Name = name;
    }
    public string Name { get; }
}