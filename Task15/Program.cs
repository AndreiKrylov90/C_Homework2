Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
if (number == 6 || number == 7)
Console.WriteLine("Это выходной день"); 
else
Console.WriteLine("Иди на работу");
}
else
{
  Console.WriteLine("Это не день недели");  
}
