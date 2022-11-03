// Вид 1
void Method1()
{
    Console.WriteLine("Автор... Газинур");
}
//Method1();
// Вид 2
void Method2(String msg)
{
    Console.WriteLine(msg);
}
// Method2("Я молодец");

void Method21(String msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Я молодец", 4);


// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);


// Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string mess = Method4(10, "235 ");
//Console.WriteLine(mess);
//Console.WriteLine("Hello, World!");

string Method41(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
//string mess1 = Method41(10, "22 ");
//Console.WriteLine(mess1);

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j}={i * j}");
    }
    Console.WriteLine();
}