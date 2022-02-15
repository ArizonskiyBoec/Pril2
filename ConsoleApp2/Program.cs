Console.WriteLine("Введите своё имя");
string a = Console.ReadLine();
while (a == null)
{
    Console.WriteLine("Вы не ввели имя.Повторите попытку");
    a = Console.ReadLine();
}
Console.WriteLine("Привет "+a);
Console.ReadKey();
