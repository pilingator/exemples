Console.WriteLine("Введите свое имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.Write("УРА, Это же МАША!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}