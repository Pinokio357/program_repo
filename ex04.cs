Console.WriteLine("������� ������ �����:");
string  strTwo = Console.ReadLine();
int two = Convert.ToInt32(strTwo);
Console.WriteLine("������� ������ �����:");
string  strthree = Console.ReadLine();
int three = Convert.ToInt32(strthree);
int max = one;
if(one < two)
 max = two;
if(three> max)
max = three;
Console.WriteLine($"������������ ����� = {max}");