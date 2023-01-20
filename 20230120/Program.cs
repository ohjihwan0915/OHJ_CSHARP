// See https://aka.ms/new-console-template for more information
#nullable disable
/*Console.Write(":");
int a = int.Parse(Console.ReadLine());
Console.Write(":");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{a} + {b} = {a+b}");
*/

/*string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

Console.WriteLine($"{name}은 {2023 + 100 - age}에 백 살이 됩니다");
*/
/*int year = int.Parse(Console.ReadLine());
if (year%4 == 0 && year%100 != 0) {
    Console.WriteLine("윤년");
}else if (year%400==0) {
    Console.WriteLine("윤년");

}else 
    Console.WriteLine("평년");
*/
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a>b && a>c) 
    Console.WriteLine(a);
    
else if(b>a && b>c)
    Console.WriteLine(b);
else 
    Console.WriteLine(c);
*/
/*
char a = 'A';

switch(a) {
    case 'A':
        Console.WriteLine("a");
        break;
    case 'B' :
        Console.WriteLine("b");
        break;
    case 'C' :
        Console.WriteLine("c");
        break;
    default:
        Console.WriteLine("..");
        break;
}*/
/*int a = 1;
int b = 0;

while (a<101) {
   
    b = a + b;
    a++;
    
}
Console.WriteLine(b);
*/
int a = int.Parse(Console.ReadLine());

/*while(a > 0) {
    Console.Write(a%10); 
    a /= 10;
}
*/
int b = 0;
while (a>0) {
    b *= 10;
    b += a%10;
    a/= 10;
}

Console.WriteLine(b);