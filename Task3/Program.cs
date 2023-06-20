// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

if(dayNum == 6 || dayNum == 7)
{
  Console.WriteLine("Этот день является выходным");
}
else if(dayNum >=1 && dayNum <=5)
{
  Console.WriteLine("Этот день не является выходным");
}
else
{
  Console.WriteLine("Такого дня недели нет");
}