// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

//Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        count++;
    }
}

Method2_1(msg: "Текст", count: 4); // Текст Текст Текст Текст
// Method2_1("Текст", 4); // вывод будет прежним
// Method2_1(count: 4, msg: "Текст");

// Вид 3

// int Method3()
// {
//     return default.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// Вид 4

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
