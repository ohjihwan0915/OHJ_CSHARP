//int r = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
/*int r = 4;
int c = 5;

int[,] a = new int[r, c];
int row = 0;
int col = 0;
int s = 1;
for(int i = 0; i < c; i++) {
    row = 0;
    col = i;
    
    while(row < r && col >= 0) {
        a[row, col] = s;
        row++;
        col --;
        s++;
    }
}

for(int i = 1; i < r; i++) {
    row = i;
    col = c-1;
    
    while(row < r && col >= 0) {
        a[row, col] = s;
        row++;
        col--;
        s++;

    }
}


for(int row = 0; row < r; row++) {
    for (int col = 0; col < c; col++) {
        Console.Write(a[row, col] + " ");

    }Console.WriteLine();
}
*/
/*
Book book1 = new Book();
Book book2 = new Book();
book1.price = 10000;
book1.page = 300;
book1.title = "a";
book1.year = 2020;

book2.price = 100009;
book2.page = 3003;
book2.title = "ab";
book2.year = 2023;
book1.getinfo();
book2.getinfo();
*/
calcu a = new calcu();
Console.WriteLine(a.add(25,12));
