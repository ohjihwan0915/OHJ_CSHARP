// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int dan = 2;
for(int a = 1; a < 10; a++) {
    for(dan = 2;dan<10; dan++) {
        Console.Write($"{dan} x {a} = {dan*a}\t");
    }
    
    Console.WriteLine();

}    
*/
/*
int n = int.Parse(Console.ReadLine());
int[] stick = new int[n];
for(int i =0; i<n; i++) {
    stick[i] = int.Parse(Console.ReadLine());
}

for(int a = 0; a < stick.Length; a++) {
    Console.WriteLine(stick[a]);
}
*/
/*
int n = 6;
int max = 0;
int count = 0;
int[] s = {6,9,7,8,4,6};
for(int a = s.Length - 1; a >= 0; a--) {
    if(max < s[a]) {
        count ++;
        max = s[a];
    }
}

Console.WriteLine(count);
*/
/*
int num = 0;
for(int a = 1; a < 6; a++) {
    while(num < a) {
        Console.Write("#");
        num++;
    }
    num = 0;
    Console.WriteLine();
}
*/
int n = 5;
int b = 1;
int c = 1;
if(b<n)
    for(;b<=n;) {
        Console.Write("#");
        b++;
    }
for(;c<n; c++) {
    if(c == n) {
         Console.Write("#");

    }else if (c==1) {
         Console.Write("#");
    }else if(c>1 && c<n) {
         Console.Write(" ");
    }
    c = 1;
     Console.WriteLine();

}




