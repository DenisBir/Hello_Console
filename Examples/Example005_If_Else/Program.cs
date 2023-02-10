Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура Маша это ты");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}