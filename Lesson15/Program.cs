//По количеству связей
//List - односвязные
//LinkedList - двусвязные
LinkedList<string> people1 = new LinkedList<string>();
List<string> names = new List<string>() { "Tom", "Jerry", "Can" };
LinkedList<string> people2 = new LinkedList<string>(names);
foreach (string name in people2)
{
    Console.Write(name + " ");
}
Console.WriteLine();
Console.WriteLine(people2.Count);
Console.WriteLine(people2.First?.Value);
Console.WriteLine(people2.Last?.Value);

var currentNode = people2.First;
while (currentNode != null)
{
    Console.Write(currentNode.Value + " ");
    currentNode = currentNode.Next;
}
Console.WriteLine();
currentNode = people2.Last;
while (currentNode != null)
{
    Console.Write(currentNode.Value + " ");
    currentNode = currentNode.Previous;
}
Console.WriteLine();
people2.AddFirst("John");
people2.AddLast("Bill");
people2.AddBefore(people2.First!, "Barak");
people2.AddAfter(people2.Last!, "Sam");
currentNode = people2.First;
while (currentNode != null)
{
    Console.Write(currentNode.Value + " ");
    currentNode = currentNode.Next;
}
Console.WriteLine();
people2.RemoveFirst();
people2.RemoveLast();
people2.Remove(people2.First!);

//по дисциплине обслуживания
//Очередь Queue принцип FIFO
//Стэк Stack принцип LIFO

//Queue

Queue<string> queue1 = new Queue<string>();
Queue<string> queue2 = new Queue<string>(names);
foreach (string name in queue2) Console.Write(name + " ");
Console.WriteLine();
Console.WriteLine(queue2.Count);
queue2.Enqueue("Sam");
queue2.Enqueue("Bob");
foreach (string name in queue2) Console.Write(name + " ");
Console.WriteLine();
Console.WriteLine(queue2.Peek());
foreach (string name in queue2) Console.Write(name + " ");
Console.WriteLine();
Console.WriteLine(queue2.Dequeue());
foreach (string name in queue2) Console.Write(name + " ");
Console.WriteLine();
Console.WriteLine(queue2.Contains("Jerry"));
queue2.Clear();

//
Stack<string> stack1 = new Stack<string>();
Stack<string> stack2 = new Stack<string>(names);
foreach (var person in stack2) Console.Write(person + " ");
Console.WriteLine();
Console.WriteLine(stack2.Count);
stack2.Push("Sam");
foreach (var person in stack2) Console.Write(person + " ");
Console.WriteLine();
Console.WriteLine(stack2.Peek());
foreach (var person in stack2) Console.Write(person + " ");
Console.WriteLine();
Console.WriteLine(stack2.Pop());
foreach (var person in stack2) Console.Write(person + " ");
Console.WriteLine();
stack2.Clear();