Console.WriteLine("введите второе число:");
string  strTwo = Console.ReadLine();
int two = Convert.ToInt32(strTwo);
Console.WriteLine("введите третье число:");
string  strthree = Console.ReadLine();
int three = Convert.ToInt32(strthree);
int max = one;
if(one < two)
 max = two;
if(three> max)
max = three;
Console.WriteLine($"максимальное число = {max}");