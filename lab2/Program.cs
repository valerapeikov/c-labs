Console.WriteLine("==========");

Console.WriteLine("Hello, Jerry");

void ABC()
{
    Console.WriteLine('A');
    Console.WriteLine('B');
    Console.WriteLine('C');
}

ABC();
Thread.Sleep(500);
ABC();
Thread.Sleep(500);
ABC();

Console.WriteLine("==========");

void A()
{
    Console.WriteLine('A');
    B();
    C();
}

void B()
{
    Console.WriteLine('B');
}

void C()
{
    Console.WriteLine('C');
}

void Main()
{
    A();
    A();
    A();
    A();
}

Main();