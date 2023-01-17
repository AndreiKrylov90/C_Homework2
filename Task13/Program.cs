Console.WriteLine("Введите любое целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 || number < -99)
{
while (number > 999 || number < -999)
{
number = number / 10;
}
int lastDigit = number % 10;
Console.WriteLine("Третья цифра введенного числа это " + Math.Abs(lastDigit)); 
}
else
{
  Console.WriteLine("Третьей цифры нет");  
}