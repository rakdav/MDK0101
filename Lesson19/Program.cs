string str = "Дудка - человек с бульвара бабуинов. Дудка - агент 00Бабуин7";
Console.WriteLine(str.DudkaCount());
var list = getBooks();
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
//1 cпособ
var query = from book in list
            where book.Author == "Омаров"
            select book;
foreach (var v in query) Console.WriteLine(v.Author + " " + v.Title);

//2 способ
List<Book> omarov = list.Where(p => p.Author == "Омаров").ToList();
foreach (var v in omarov) Console.WriteLine(v.Author + " " + v.Title);

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
