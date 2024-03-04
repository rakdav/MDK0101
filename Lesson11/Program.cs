Calculator calc = new Calculator();
//одиночный делегат
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine()!);
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine()!);
Console.Write("Введите операцию +,-,* или /:");
char op = char.Parse(Console.ReadLine()!);
CalcDelegate? operation=null;
switch (op)
{
    case '+': operation = new CalcDelegate(calc.Add);break;
    case '-': operation = new CalcDelegate(calc.Sub); break;
    case '*': operation = new CalcDelegate(calc.Mult); break;
    case '/': operation = new CalcDelegate(calc.Div); break;
    default: throw new InvalidOperationException();
}
Console.WriteLine($"Результат:{operation(x,y)}");
//множественный делегат
CalcDelegate multDelegate = calc.Add;
multDelegate += calc.Sub;
multDelegate += calc.Mult;
multDelegate += calc.Div;
foreach(CalcDelegate item in multDelegate.GetInvocationList())
{
    Console.WriteLine(item(x,y));
}
multDelegate -= calc.Mult;
foreach (CalcDelegate item in multDelegate.GetInvocationList())
{
    Console.WriteLine(item(x, y));
}

ExampleClass example = new ExampleClass();
int a = 6, b = 9;
AddDelegate<int> addInt = example.AddInt;
Console.WriteLine($"{a}+{b}={addInt(a,b)}");
AddDelegate<double> addDouble = example.AddDouble;
Console.WriteLine($"{x}+{y}={addDouble(x,y)}");
char c1 = 'f', c2 = 'e';
AddDelegate<char> addChar = ExampleClass.AddChar;
Console.WriteLine($"{c1}+{c2}={addChar(c1,c2)}");

public delegate double CalcDelegate ( double x, double y );
public delegate T AddDelegate<T> (T x,T y);
public class ExampleClass
{
    public int AddInt(int x,int y )
    {
        return x + y;
    }
    public double AddDouble(double x,double y )
    {
        return x + y;
    }
    public static char AddChar(char x,char y )
    {
        return (char)(x+y);
    }
}
public class Calculator
{
    public double Add (double x,double y)
    {
        return x + y;
    }
    public double Sub(double x,double y )
    {
        return x - y;
    }
    public double Mult(double x,double y )
    {
        return x * y;
    }
    public double Div(double x,double y )
    {
        if (y != 0)
            return x / y;
        throw new DivideByZeroException();
    }
}


