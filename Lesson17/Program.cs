//using System.Net.Http.Headers;

//DriveInfo[] drives = DriveInfo.GetDrives();
//foreach(DriveInfo d in drives)
//{
//    Console.WriteLine(d.Name);
//    Console.WriteLine(d.TotalSize);
//    Console.WriteLine(d.VolumeLabel);
//    Console.WriteLine(d.DriveFormat);
//    Console.WriteLine(d.AvailableFreeSpace);
//    Console.WriteLine(d.IsReady);
//    Console.WriteLine(d.TotalFreeSpace);
//    Console.WriteLine(d.RootDirectory);
//}

//FileStream? fs = null;
//try
//{
//    fs = new FileStream("text.txt", FileMode.OpenOrCreate);
//}
//catch(IOException ex)
//{

//}
//finally
//{
//    fs!.Close();
//}
using System.Text;

//запись в файл
//Console.Write("Введите текст:");
//string text = Console.ReadLine()!;
//using (FileStream fs = new FileStream("text.txt", FileMode.OpenOrCreate))
//{
//    byte[] buffer = Encoding.Unicode.GetBytes(text);
//    //fs.Write(buffer, 0, buffer.Length);//синхронный
//    await fs.WriteAsync(buffer, 0, buffer.Length);//асинхронно
//}

////чтение из файла
//using (FileStream fs = new FileStream("text.txt", FileMode.Open))
//{
//    byte[] buffer = new byte[fs.Length];
//    await fs.ReadAsync(buffer, 0, buffer.Length);
//    string text = Encoding.Unicode.GetString(buffer);
//    Console.WriteLine(text);
//}

//using (FileStream fs = new FileStream("text.txt", FileMode.Open))
//{
//    fs.Seek(6, SeekOrigin.Begin);
//    byte[] buffer = new byte[10];
//    await fs.ReadAsync(buffer, 0, buffer.Length);
//    string text = Encoding.Unicode.GetString(buffer);
//    Console.WriteLine(text);
//}

//текстовые файлы
//Console.Write("Введите название файла:");
//string nameFile = Console.ReadLine()!;
//Console.Write("Введите текст:");
//string text = Console.ReadLine()!;
//using (StreamWriter sw = new StreamWriter(nameFile,false))
//{
//    await sw.WriteAsync(text);
//}

//using (StreamWriter sw = new StreamWriter(nameFile, true))
//{
//    await sw.WriteAsync("Без него хорошо.");
//}

//using(StreamReader sr=new StreamReader(nameFile))
//{
//    Console.WriteLine(await sr.ReadToEndAsync());
//}

//using (StreamReader sr = new StreamReader(nameFile))
//{
//    string? line;
//    while ((line = await sr.ReadLineAsync()) != null)
//    {
//        Console.WriteLine(line);
//    }
//}

//бинарные файлы
//List<Person> people = new List<Person>();
//people.Add(new Person("Маша", 17));
//people.Add(new Person("Дудкина любовь", 18));
//using (BinaryWriter writer = new BinaryWriter(new FileStream("people.dat", FileMode.OpenOrCreate)))
//{
//    foreach(Person p in people)
//    {
//        writer.Write(p.Name);
//        writer.Write(p.Age);
//    }
//}
List<Person> people = new List<Person>();
using (BinaryReader reader = new BinaryReader(new FileStream("people.dat", FileMode.Open)))
{
    while (reader.PeekChar()>-1) 
    {
        string name = reader.ReadString();
        int age = reader.ReadInt32();
        Person person = new Person(name, age);
        people.Add(person);
    }
}
foreach(Person p in people)
{
    Console.WriteLine(p.Name+" "+p.Age);
}
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}



