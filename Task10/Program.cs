Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
int newnumber = number / 10;
int secondDigit = newnumber % 10;
Console.WriteLine("Вторая цифра трехзначного числа " + number + " это " + secondDigit); 
}
else
{
  Console.WriteLine("Сказано было трехзначное число");  
}

