Console.Write("Введите имя");
string username = Console.ReadLine();

if(username.ToLower() == " кирилл")
{
Console.WriteLine("Привет, Любовь моя!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine( username);
}