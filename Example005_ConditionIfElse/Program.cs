Console.WriteLine("Введите Ваше имя...");
string username = Console.ReadLine();

if (username.ToLower() == "сергей")
{
    Console.WriteLine("Ура, это же Серёжа!");
}
else
{
    Console.Write("Привет, " + username);
}