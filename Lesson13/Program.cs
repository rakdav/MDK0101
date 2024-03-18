//*******Action**********//
using static System.Net.Mime.MediaTypeNames;

Action<string, ConsoleColor, int> actionTarget = DisplayMessage;
actionTarget("Hello!", ConsoleColor.Yellow, 5);
//*******Func************//
Func<int, int, int> funcTarget = Add;
int result = funcTarget.Invoke(40,20);
Console.WriteLine($"40+20={result}");

Func<int, int, string> funcTarget2 = SumToString;
string sum = funcTarget2(90, 100);
Console.WriteLine($"90+100={sum}");
//*******Predicate************//
Predicate<int> positive = IsPositive;
Console.WriteLine(IsPositive(20));
Console.WriteLine(IsPositive(-20));
//*******Анонимные методы************//
MessageHandler handler = delegate ( string msg )
{
    Console.WriteLine(msg);
};
handler("Hello, world");
Operation op = delegate ( int x, int y )
{
    return x + y;
};
Console.WriteLine(op(6,9));
//*******Лямбда выражения************//
Message hello=() => Console.WriteLine("Hello");
hello();
Console.WriteLine(AddInt(3,8));
//int AddInt(int x,int y )
//{
//    return x + y;
//}
int AddInt ( int x, int y ) => x + y;
Operation sumOper = ( x, y ) => x + y;
Operation subOper = ( x, y ) => x - y;
Console.WriteLine(subOper(6,8));
Console.WriteLine(sumOper(6,3));
//*******Анонимные типы************//
var a=6;
var b = 4.6;
var c = "Сорока лошарик";
var user = new { FIO = "Иванов Иван Иванович", Age = 25 };
Console.WriteLine(user.FIO);
Console.WriteLine(a);
Console.WriteLine(b);
//*******Замыкания************//
var fn = Outer();
fn();
fn();
Action Outer ()
{
    int x = 5;
    void Inner ()
    {
        x++;
        Console.WriteLine(x);
    }
    return Inner;
}
var outerFn = () =>
{
    int x = 10;
    var innerFn = () => Console.WriteLine(++x);
    return innerFn;
};
var f = outerFn();
f();
f();
//*************Ковариантность делегатов***************//
MessageBuilder mb = WriteEmailMassage;
MessageClass message = mb("Hello");
message.Print();
//*************Контрвариантность делегатов***************//
EmailReceiver emailBox = ReceiveMessage;
emailBox(new EmailMessage("Welcome"));
static bool IsPositive (int x)
{
    return x > 0;
} 
static int Add(int x,int y )
{
    return x + y;
}
static string SumToString(int x,int y )
{
    return ( x + y ).ToString();
}

static void DisplayMessage (string msg, ConsoleColor txtColor,int printCount)
{
    ConsoleColor previus = Console.ForegroundColor;
    Console.ForegroundColor = txtColor;
    for (int i = 0; i < printCount; i++)
    {
        Console.WriteLine(msg);
    }
    Console.ForegroundColor = previus;
}


EmailMessage WriteEmailMassage (string text)=>new EmailMessage(text);
void ReceiveMessage ( MessageClass message ) => message.Print();
delegate void MessageHandler (string message);
delegate int Operation(int x,int y);
delegate void Message();
delegate MessageClass MessageBuilder ( string text );
delegate void EmailReceiver ( EmailMessage message );
class MessageClass
{
    public string Text { get; }
    public MessageClass ( string text ) => Text = text;
    public virtual void Print () => Console.WriteLine(Text);
}
class EmailMessage : MessageClass
{
    public EmailMessage ( string text ) : base(text)
    {
    }

    public override void Print () => Console.WriteLine("Email:"+Text);
}
class SmsMessage : MessageClass
{
    public SmsMessage ( string text ) : base(text)
    {
    }
    public override void Print () => Console.WriteLine("SMS:" + Text);
}