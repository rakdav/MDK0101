//File
//FileStream fs = File.Create("file.txt");
//File.Copy("file.txt", "copy.txt");
//if (File.Exists("copy.txt"))
//{
//    File.Move("copy.txt","move.txt");
//}
//if(File.Exists("file.txt")&& File.Exists("move.txt"))
//{
//    File.Replace("file.txt", "move.txt", "backup.txt");
//}
//using System.Text;

//if (File.Exists("move.txt"))
//{
//    using (FileStream fs = File.Open("move.txt", FileMode.Open))
//    {
//        byte[] buffer = new byte[fs.Length];
//        await fs.ReadAsync(buffer, 0, buffer.Length);
//        string text = Encoding.Default.GetString(buffer);
//        Console.WriteLine(text);
//    }
//}

//File.Delete("move.txt");

//FileInfo
//using System.Text;

//FileInfo fileInfo = new FileInfo("file.txt");
//if (!fileInfo.Exists)
//{
//    fileInfo.Create();
//    Console.WriteLine(fileInfo.Name);
//    Console.WriteLine(fileInfo.FullName);
//    Console.WriteLine(fileInfo.Length);
//    Console.WriteLine(fileInfo.Attributes);
//    Console.WriteLine(fileInfo.CreationTime);
//    Console.WriteLine(fileInfo.Directory);
//    Console.WriteLine(fileInfo.DirectoryName);

//}
//fileInfo.Encrypt();
//fileInfo.Decrypt();
//using (FileStream fs = fileInfo.Open(FileMode.Open))
//{

//    byte[] buffer = new byte[fs.Length];
//    await fs.ReadAsync(buffer, 0, buffer.Length);
//    string text = Encoding.Default.GetString(buffer);
//    Console.WriteLine(text);
//}

string currentDirectory = Environment.CurrentDirectory;
DirectoryInfo dInfo = new DirectoryInfo(currentDirectory);
while (true)
{
    Console.Write(dInfo.FullName+">");
    string command = Console.ReadLine()!;
    string[] commands = command.Split(" ");
    switch (commands[0])
    {
        case "cd":
            {
                switch (commands[1]) 
                {
                    case "..":
                                dInfo = dInfo.Parent!;
                                break;
                    case "/":
                                dInfo = dInfo.Root;
                                break;
                    default:
                                dInfo = new DirectoryInfo(commands[1]);
                                break;
                }
            }
            break;
        case "ls":
            {
                DirectoryInfo[] allDir = dInfo.GetDirectories();
                foreach(DirectoryInfo di in allDir)
                {
                    Console.WriteLine(di.Name);
                }
                FileInfo[] allFiles = dInfo.GetFiles();
                foreach (FileInfo fi in allFiles)
                {
                    Console.WriteLine(fi.Name);
                }
            }
            break;
        case "touch":
            FileStream file = File.Create(commands[1]);
            break;
    }
}