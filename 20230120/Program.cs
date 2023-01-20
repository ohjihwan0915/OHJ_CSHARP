// See https://aka.ms/new-console-template for more information
#nullable disable
/*Console.Write(":");
int a = int.Parse(Console.ReadLine());
Console.Write(":");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{a} + {b} = {a+b}");
*/

string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

Console.WriteLine($"{name}은 {2023 + 100 - age}에 백 살이 됩니다");