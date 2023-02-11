/*
using System;

int[] q = new int[] {-1, -1, -1, -1};
int count = 0;
Random rand = new Random();
while(count < 4) {
    int t = rand.Next(0,10);
    if(count == 0 && t ==0)
        continue;
    bool notExist = true;
    for(int i = 0; i<count; i++) {
        if(t==q[i]){
            notExist = false;
            break;
        }
    }
    if(notExist) {
        q[count++] = t;
    }
}

Console.WriteLine("game start");


int s = 0;
int b = 0;
int c = 0;
string answer;
while(s!=4) {
    c+=1;
    s = b =  0;
    answer = Console.ReadLine();
    if (answer.Length != 4) {
        Console.WriteLine("4글자를 입력하시오");
        c -= 1;
        continue;
    }
    
    for (int i = 0; i <answer.Length; i++) {
        int t = int.Parse(answer[i].ToString());
        for(int j = 0; j < q.Length; j++) {
            if(t ==q[j]) {
                if(i == j) {
                    s++;
                }
                else {
                    b++;

                }
                break;
            }
        }
        
    }
    Console.WriteLine($"{answer} : {s} s, {b} b");

}

Console.WriteLine($"{c}번에서 맞췄습니다");


*/