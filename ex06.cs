Console.WriteLine("введите число:");
string numberstr = Console.ReadLine();
int number = Convert.ToInt32(numberstr);

if(number % 2 == 0)
Console.WriteLine($"число {number} четное");
else
Console.WriteLine($"число {number} нечетное");