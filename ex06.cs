Console.WriteLine("������� �����:");
string numberstr = Console.ReadLine();
int number = Convert.ToInt32(numberstr);

if(number % 2 == 0)
Console.WriteLine($"����� {number} ������");
else
Console.WriteLine($"����� {number} ��������");