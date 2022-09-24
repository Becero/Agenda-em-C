#include<stdio.h>
#include<stdlib.h>

void Ordena(a,b,c){
            int x;
            if (a > b)
            {
                x = a;
                a = b;
                b = x;
            }
            if (a > c)
            {
                x = c;
                c = a;
                c = x;
            }
            if (b > c)
            {
                x = c;
                c = b;
                b = x;
            }
}
int main(void){

    int a,b,c;
    scanf("%d%d%d",&a,&b,&c);
    Ordena(a,b,c);
    printf("%d\n%d\n%d\n",a,b,c);
    return 0;
}
