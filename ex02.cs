Console.WriteLine("������� ������ �����:");
string  strOne = Console.ReadLine();
int one = Convert.ToInt32(strOne);
Console.WriteLine("������� ������ �����:");
string  strTwo = Console.ReadLine();
int two = Convert.ToInt32(strTwo);
if(one > two)
Console.WriteLine($"������� ����� = {one} ������� ����� = {two}");
else if(two > one)
Console.WriteLine($"������� ����� = {two} ������� ����� = {one}");
else
    Console.WriteLine($"����� �����");