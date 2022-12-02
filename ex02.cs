Console.WriteLine("введите первое число:");
string  strOne = Console.ReadLine();
int one = Convert.ToInt32(strOne);
Console.WriteLine("введите второе число:");
string  strTwo = Console.ReadLine();
int two = Convert.ToInt32(strTwo);
if(one > two)
Console.WriteLine($"большее число = {one} меньшее число = {two}");
else if(two > one)
Console.WriteLine($"большее число = {two} меньшее число = {one}");
else
    Console.WriteLine($"числа равны");