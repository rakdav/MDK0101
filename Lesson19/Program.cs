//string str = "Дудка - человек с бульвара бабуинов. Дудка - агент 00Бабуин7";
//Console.WriteLine(str.DudkaCount());
//var list = getBooks();
//string[] colors = { "Red", "Brown", "Orange", "Yellow", "Black", "Green", "White", "Violet", "Blue" };

//IEnumerable<string> results = from c in colors
//                              where c.StartsWith("B")
//                              orderby c
//                              select c;
//colors[4] = "Slate";
//foreach (var color in results)
//{
//    Console.Write(color+", ");
//}
//Console.WriteLine();
//var numbers = Enumerable.Empty<long>();
//foreach (var color in numbers)
//{
//    Console.Write(color + ", ");
//}
//Console.WriteLine();
//var numbersRange = Enumerable.Range(1, 5);
//foreach (var color in numbersRange)
//{
//    Console.Write(color + ", ");
//}
//Console.WriteLine();
//var numbersRepeat = Enumerable.Repeat(10, 5);
//foreach (var color in numbersRepeat)
//{
//    Console.Write(color + ", ");
//}
//Console.WriteLine();
//Console.WriteLine(GetCars().All(c => c.Year > 1960));
//Console.WriteLine(GetCars().Any(c => c.Year <= 1960));
//var strings = new MyStringList { "orange", "apple", "grape", "pear" };
//foreach (var item in strings.Where(s => s.Length == 5))
//{
//    Console.Write(item+",");
//}
//Console.WriteLine();

//var querable = strings.AsQueryable();
//Console.WriteLine("Element Type: {0}", querable.ElementType);
//Console.WriteLine("Expression: {0}", querable.Expression);
//Console.WriteLine("Provider: {0}", querable.Provider);

//int[] scores = { 88, 56, 23, 99, 65, 93, 78, 23, 99, 90 };
//var evenScores = scores.Where(s => s % 2 == 0).ToList(); // ToArray()
//scores[2] = 2;
//foreach (var item in evenScores)
//{
//    Console.WriteLine(item+" ");
//}
//Console.WriteLine();

//var cars = GetCars();
//var carsByVin = cars.ToDictionary(c => c.VIN);
//Car myCar = carsByVin["HIJ123"];
//Console.WriteLine("Car VIN:{0}, Make:{1}, Model:{2} Year:{3}",
//                    myCar.VIN, myCar.Make, myCar.Model, myCar.Year);

//IEnumerable<Object> objects = scores.Cast<object>();

//object[] items = new object[] { 55, "Hello", 22, "Goodbye" };
//foreach (var intItem in items.OfType<int>())
//{
//    Console.WriteLine(intItem+" ");
//}
//Console.WriteLine();
//Console.WriteLine("Max: " + scores.Max());
//Console.WriteLine("Min: " + scores.Min());
//Console.WriteLine("Average: " + scores.Average());
//Console.WriteLine("Sum: " + scores.Sum());
//Console.WriteLine("Count: " + scores.Count());
//Console.WriteLine(scores.ElementAt(4));
//Console.WriteLine(scores.First());
//Console.WriteLine(scores.Last());

//int[] scoresEmpty = { };
//Console.WriteLine(scoresEmpty.ElementAtOrDefault(4));
//Console.WriteLine(scoresEmpty.FirstOrDefault());
//Console.WriteLine(scoresEmpty.LastOrDefault());

//int score1 = scores.Where(x => x > 50 && x < 60).Single();
//int score2 = scores.Where(x => x > 100).SingleOrDefault();
//Console.WriteLine(score1);
//Console.WriteLine(score2);

//List<Car> carsList = new List<Car>();
//IEnumerable<Car> oneNullCar = cars.DefaultIfEmpty();
//foreach (var car in oneNullCar)
//{
//    Console.WriteLine(car == null ? "Null Car" : "Not Null Car");
//}

//Console.WriteLine(scores.Contains(56));
//Console.WriteLine(scores.Contains(24));

//foreach (var score in scores.Distinct())
//{
//    Console.Write(score+" ");
//}
//Console.WriteLine();

//int[] lastYearScores = { 88, 56, 23, 99, 65 };
//int[] thisYearScores = { 93, 78, 23, 99, 90 };

//foreach (var item in lastYearScores.Concat(thisYearScores))
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();

//foreach (var item in lastYearScores.Except(thisYearScores))
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine();

//foreach (var item in lastYearScores.Intersect(thisYearScores))
//{
//    Console.WriteLine(item+ " ");
//}
//Console.WriteLine();

//var allScores = lastYearScores.Union(thisYearScores);
//foreach (var item in allScores.OrderBy(s => s))
//{
//    Console.WriteLine(item+" ");
//}
//Console.WriteLine();

//foreach (var score in scores.Reverse())
//{
//    Console.Write(score+" ");
//}
//Console.WriteLine();

//List<int> lastYearScoresList = new List<int> { 93, 78, 23, 99, 91 };
//List<int> thisYearScoresList = new List<int> { 93, 78, 23, 99, 90 };
//Console.WriteLine(lastYearScores.SequenceEqual(thisYearScores));
//lastYearScores[4] = 90;
//Console.WriteLine(lastYearScores.SequenceEqual(thisYearScores));

//Console.WriteLine("******skip**********");
//int[] scoresSkip = {88, 56, 23, 99, 65, 93, 78, 23, 99, 90 };
//foreach (var s in scoresSkip.OrderBy(i => i).Skip(9))
//{ Console.Write(s+" "); }
//Console.WriteLine();
//Console.WriteLine("******skipWhile**********");
//foreach (var s in scores.OrderBy(i => i).SkipWhile(s => s < 80))
//{ Console.Write(s+" "); }
//Console.WriteLine();
//Console.WriteLine("******Take**********");
//foreach (var item in scores.OrderBy(i => i).Skip(3).Take(2))
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();
//Console.WriteLine("******TakeWhile**********");
//foreach (var item in scores.OrderBy(i => i).TakeWhile(s => s < 80))
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();

//Console.Write("Введите размер массива:");
//int n = int.Parse(Console.ReadLine()!);
//int[] mas = new int[n]; 
//Random r = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = r.Next(-10, 20);
//}
//mas = mas.Select(i => i + r.Next(-10, 20)).ToArray(); 
//foreach (int item in mas)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();

//Console.WriteLine(mas.Where(i=>i%2==0).Sum());
//Console.WriteLine(mas.Aggregate((x,y)=>x*y));
//Console.WriteLine(mas.Sum(i=>i*i));
//Console.WriteLine(mas.Skip(6).Sum());
//int k1 = 2, k2 = 10;
//Console.WriteLine(mas.Where((i,j)=>j>=k1&&j<=k2).Sum());
//Console.WriteLine(mas.Average());
//Console.WriteLine(mas.Where((i, j) => j >= k1 && j <= k2).Average());

//foreach(int i in mas.Where(i=>i>=0))
//    Console.Write(i+" ");
//Console.WriteLine();


using System.Collections.Generic;

List<Car> GetCars()
{
    return new List<Car>
                {
                    new Car { VIN = "ABC123", Make = "Ford",
                            Model = "F-250", Year = 2000 },
                    new Car { VIN = "DEF123", Make = "BMW",
                            Model = "Z-3", Year = 2005 },
                    new Car { VIN = "ABC456", Make = "Audi",
                            Model = "TT", Year = 2008 },
                    new Car { VIN = "HIJ123", Make = "VW",
                            Model = "Bug",  Year = 1956  },
                    new Car { VIN = "DEF456", Make = "Ford",
                            Model = "F-150", Year = 2005 }
                };
}

List<Book> getBooks()
{
    return new List<Book> {
        new Book
        {
            Author="Дудка",
            Title="Делать нечего",
            NumberOfCopies=10,
            Category="Безделушка",
            Year=2023
        },
        new Book
        {
            Author="Омаров",
            Title="Дурью маюсь",
            NumberOfCopies=5,
            Category="Бестселлер",
            Year=2023
        }
    };
}
List<Repair> GetRepairs()
{
    return new List<Repair> {
        new Repair {VIN = "ABC123", Desc = "Change Oil", Cost = 29.99m},
        new Repair {VIN = "DEF123", Desc = "Rotate Tires",  Cost =19.99m},
        new Repair {VIN = "HIJ123", Desc = "Replace Brakes",   Cost = 200},
        new Repair {VIN = "DEF456", Desc = "Alignment", Cost = 30},
        new Repair {VIN = "ABC123", Desc = "Fix Flat Tire", Cost = 15},
        new Repair {VIN = "DEF123", Desc = "Fix Windshield",  Cost =420},
        new Repair {VIN = "ABC123", Desc = "Replace Wipers", Cost = 20},
        new Repair {VIN = "HIJ123", Desc = "Replace Tires",   Cost = 1000},
        new Repair {VIN = "DEF456", Desc = "Change Oil", Cost = 30} };
}


List<Car> cars = GetCars();
List<Car> filtered = new List<Car>();
List<FilterPredicate> predicates = new List<FilterPredicate>();
//predicates.Add(delegate (Car car) { return car.Year > 2000; });
//predicates.Add(delegate (Car car) { return car.Model.StartsWith("F"); });

//predicates.Add((Car car) => car.Year > 2000);
//predicates.Add((Car car) => car.Model.StartsWith("F"));

//predicates.Add(car => car.Year > 2000);
//predicates.Add(car => car.Model.StartsWith("F"));
//Console.WriteLine(GetCars().All(c => c.Year > 1960));
//Console.WriteLine(GetCars().Any(c => c.Year > 1960));
////var carsByVin = cars.ToDictionary(c => c.VIN);
//var carsByVin = cars.ToLookup(c => c.VIN);
//IEnumerable<Car> myCars = carsByVin["HIJ123"];
//foreach(Car myCar in myCars)
//Console.WriteLine("Car VIN:{0}, Make:{1}, Model:{2} Year:{3}",
//                    myCar.VIN, myCar.Make, myCar.Model, myCar.Year);

//var numbers = Enumerable.Range(1, 1000);
//var zip = numbers.Zip(cars, (i, c) => new
//{
//    Number = i,
//    CarMake = c.Make,
//    CarModel=c.Model
//});

//foreach(var i in zip)
//{
//    Console.WriteLine("Car number:{0}, Make:{1}, Model:{2}",
//                    i.Number, i.CarMake, i.CarModel);
//}
//foreach (Car item in cars)
//{
//    if (item.Year > 2000 && item.Model.StartsWith("F"))
//    {
//        filtered.Add(item);
//    }
//}

//foreach (Car item in cars)
//{
//    if (FilterYear(item) && FilterModel(item))
//    {
//        filtered.Add(item);
//    }
//}

//foreach (Car item in cars)
//{
//    if (CheckPredicates(item, predicates)) { filtered.Add(item); }
//}

//группировка
//var query = cars.GroupBy(c => c.Make);
//foreach (IGrouping<string, Car> group in query)
//{
//    Console.WriteLine("Key:{0}", group.Key);
//    foreach (Car c in group)
//    { 
//        Console.WriteLine("Car VIN:{0} Make:{1}", c.VIN, c.Make); 
//    }
//}

//сортировка
//var carsSort = cars.OrderBy(c => c.Make)
//                            .ThenByDescending(c => c.Model)
//                            .ThenBy(c => c.Year);
//foreach (var item in carsSort)
//{
//    Console.WriteLine("Car VIN:{0} Make:{1} Model:{2} Year:{3}",
//        item.VIN, item.Make, item.Model, item.Year);
//}

//Фильтр
//foreach (var myCar in cars.Where(c => c.Make == "Ford"))
//{
//    Console.WriteLine("Car VIN:{0}, Make:{1}, Model:{2} Year:{3}",
//                        myCar.VIN, myCar.Make, myCar.Model, myCar.Year);
//}

//кортежи
//var tuple = (5, 10);
//(int,int,int) tuple = (5, 10,15);
//Console.WriteLine(tuple.Item1);
//Console.WriteLine(tuple.Item2);
//tuple.Item1 += 26;
//Console.WriteLine(tuple.Item1);


//select
//var vehicles = new List<Tuple<string, string, int>>
//            {
//                Tuple.Create("123", "VW", 1999),
//                Tuple.Create("234", "Ford", 2009),
//                Tuple.Create("567", "Audi", 2005),
//                Tuple.Create("678", "Ford", 2003),
//                Tuple.Create("789", "Mazda", 2003),
//                Tuple.Create("999", "Ford", 1965)
//            };
//var fordCars = vehicles
//                        .Where(v => v.Item2 == "Ford")
//                        .Select(v => new Car
//                        {
//                            VIN = v.Item1,
//                            Make = v.Item2,
//                            Year = v.Item3
//                        });
//foreach (var item in fordCars)
//{
//    Console.WriteLine("Car VIN:{0} Make:{1} Year:{2}",
//              item.VIN, item.Make, item.Year);
//}

//var fordCars = from v in vehicles
//               let makeYear = v.Item2 + " " + v.Item3
//               where makeYear.StartsWith("Ford")
//               select new
//               {
//                   VIN = v.Item1,
//                   MakeYear = makeYear
//               };
//foreach (var item in fordCars)
//{
//    Console.WriteLine("Car VIN:{0} MakeYear:{1}",
//                        item.VIN, item.MakeYear);
//}

//selectMany
//var repairs = new List<Tuple<string, List<string>>>
//                    {
//                        Tuple.Create("ABC123",
//                                    new List<string> {"Rotate Tires", "Change oil"}),
//                        Tuple.Create("DEF123",
//                                    new List<string> {"Fix Flat", "Wash Vehicle"}),
//                        Tuple.Create("ABC456",
//                                    new List<string> {"Alignment", "Vacuum", "Wax"}),
//                        Tuple.Create("HIJ123",
//                                    new List<string> {"Spark plugs", "Air filter"}),
//                        Tuple.Create("DEF456",
//                                    new List<string> {"Wiper blades", "PVC valve"}),
//                    };
//var query = repairs.SelectMany(t =>
//        t.Item2.Select(r => new { VIN = t.Item1, Repair = r }));

//foreach (var item in query)
//{
//    Console.WriteLine("VIN:{0} Repair:{1}", item.VIN, item.Repair);
//}

//join
//var makes = new string[] { "Audi", "BMW", "Ford", "Mazda", "VW" };
//var query = makes.GroupJoin(cars,
//    make => make, car => car.Make,
//    (make, innerCar) => new { Make = make, Car = innerCar });
//foreach (var item in query)
//{
//    Console.WriteLine("Make: {0}", item.Make);
//    foreach (var car in item.Car)
//        Console.WriteLine("Make: {0}, Car:{1} {2} {3}",
//                        car.Make,car.Model,car.Year,car.VIN);
//}




//foreach (Car item in filtered)
//{
//    Console.WriteLine(item.Model+" "+item.VIN+" "+item.Make+" "+item.Year+" "+item.Color);
//}

//Inner Join
var repairs = GetRepairs();
//var carsWithRepairs = from c in cars
//                      join r in repairs
//                      on c.VIN equals r.VIN
//                      orderby c.VIN, r.Cost
//                      select new
//                      {
//                          c.VIN,
//                          c.Make,
//                          r.Desc,
//                          r.Cost
//                      };
//foreach (var item in carsWithRepairs)
//{
//    Console.WriteLine("Car VIN:{0}, Make:{1}, Description:{2} Cost:{3:C}",
//        item.VIN, item.Make, item.Desc, item.Cost);
//}


//var carsWithRepairs = from c in cars
//                      join r in repairs
//                      on c.VIN equals r.VIN into g
//                      from r in g.DefaultIfEmpty()
//                      orderby c.VIN, r == null ? 0 : r.Cost
//                      select new
//                      {
//                          c.VIN,
//                          c.Make,
//                          Desc = r == null ? "***No Repairs***" : r.Desc,
//                          Cost = r == null ? 0 : r.Cost
//                      };
//foreach (var item in carsWithRepairs)
//{
//    Console.WriteLine("Car VIN:{0}, Make:{1}, Description:{2} Cost:{3:C}",
//        item.VIN, item.Make, item.Desc, item.Cost);
//}

var colors = new string[] { "Red", "Blue", "Green" };

var carsWithRepairs = from car in cars
                      from color in colors
                      orderby car.VIN, color
                      select new
                      {
                          car.VIN,
                          car.Make,
                          car.Model,
                          Color = color
                      };
foreach (var item in carsWithRepairs)
{
    Console.WriteLine("Car VIN:{0}, Make:{1}, Model:{2} Color:{3}",
                    item.VIN, item.Make, item.Model, item.Color);
}

bool CheckPredicates(Car car, IList<FilterPredicate> predicates)
{
    foreach (FilterPredicate p in predicates)
    {
        if (!p(car)) { return false; }
    }

    return true;
}
bool FilterYear(Car car) { return car.Year > 2000; }
bool FilterModel(Car car) { return car.Model.StartsWith("F"); }
delegate bool FilterPredicate(Car car);





public class MyStringList : List<string>
{
    public IEnumerable<string> Where(Predicate<string> filter)
    {
        return this.Select(s => filter(s) ? s.ToUpper() : s);
    }
}

public class Repair
{
    public string VIN { get; set; }
    public string Desc { get; set; }
    public decimal Cost { get; set; }
}

public class Car
{
    public string VIN { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
}

public class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Category { get; set; }
    public int Year { get; set; }
    public int NumberOfCopies { get; set; }
}


public static class MyExtension
{
    public static int DudkaCount(this string s)
    {
        string[] mas = s.Split(' ', ',','.');
        int count = 0;
        foreach(var i in mas)
        {
            if (i == "Дудка") count++;
        }
        return count;
    }
}
