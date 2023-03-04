/*
void swap(int a, int b) {
    int temp = a;
    a = b;
    a = temp;
    Console.WriteLine($"swap : {a} {b}");
}

void swapref(ref int a, ref int b) {
    int temp = a;
    a = b;
    a = temp;
    Console.WriteLine($"swapref : {a} {b}");
}

void swapin(in int a, in int b)  {
    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine($"in : {a} {b}");
}


int addandMul(int a, int b, out int mulResult) {
    mulResult = a * b;
    return a + b;
}
int a = 22, b = 123;
Console.WriteLine($"main : {a} {b}");
swap(a, b);
Console.WriteLine($"main : {a} {b}");
swapref(ref a, ref b);
Console.WriteLine($"main : {a} {b}");
int mulResult; 
int add = addandMul(a, b, out mulResult);
Console.WriteLine($"add and mul : {add} {mulResult}");
*/
/*
int add(int n) {
    int i;
    if(n == 1) {
        return 1;
    }
    return n + add(n-1);
}
Console.WriteLine(add(100));
*/
/*
void h(int n) {
    if (n == 0) {
        return;
    }
    
    
    h(n/2);
    Console.Write(n % 2);
}

h(255);
*/
/*
int n = 5;
for(int i = 1; i <= n; i++) {
    for(int j = n - 1; j>1; j--) {
        Console.Write(1 + j*i);
        if(i%n==0) {
            Console.WriteLine();
        }
    }
}
*/

int n = 5;
for(int row = 1; row <= n; row++) {
    for(int i = 0; i < n; i++) {
        Console.Write(row + n*i);
        
    }
    Console.WriteLine();

}