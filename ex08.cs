Console.WriteLine("������� �����:");
string  strN = Console.ReadLine();
int N= Convert.ToInt32(strN);



if(N >2)
{
int count = 2;
while(count < N)
Console.Write($"{count},");
count = count + 2;
}
else if( N < -2)
{
int count = -2;
while(count > N)
Console.Write($"{count},");
count = count -2;
}
else
Console.WriteLine($"������ ����� ����� {N}  � 1 ���");