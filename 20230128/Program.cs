// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a = int.Parse(Console.ReadLine());
int b = 0;
while (a>0) {
    b*=10;
    b+=a%10;
    a/=10;
    
}

Console.WriteLine(b);
*/
/*
for(int dan = 2; dan<10; dan++) {
    Console.WriteLine($"{dan}단");
    for(int i=1; i<10;i++) {
        Console.WriteLine($"{dan} x {i} = {dan*i}");
    }
    Console.WriteLine();
}
*/
/*
for (int row = 10; row>0; row--) {
    for (int col= 0; col < row;col++) {
        Console.Write("*");
    } 
    Console.WriteLine();
 }
 */
 /*for(int i = 1; i <101; i++) { 
    if(i>50)
        break;
    Console.WriteLine(i);
 }
 
 for(int i = 1; i<101; i++) {
    if(i%2==0)
        continue;
    Console.WriteLine(i);
 }
 */

 /*int[] a = new int[] {1,2,3,4,5,6,7,8,9,10};
 Console.WriteLine(a[0]);
 a[2] = 100;
 Console.WriteLine(a[2]);
 Console.WriteLine(a.Length);
 for(int i=a.Length - 1; i>-1; i--) {
    Console.WriteLine(a[i]);
 }

 foreach (int v in a) {
    Console.WriteLine(v);
 }
 */
 int inp = 0;
 do{
    Console.Write("숫자 1을 입력하세요 : ");
    inp = int.Parse(Console.ReadLine());

 }while(inp != 1);
Console.WriteLine("잘했어요");