//Prova Marques
#include<stdio.h>
#include<stdlib.h>

void fantasma(int buu)
{
        int *i;
    i = &buu;
    buu = 10;
}
int main(void){
 int var = 277,num =3;
 for( int i=9; i<var; i++)
 {
     printf("%d\n",i); //9,10,11,12,13
     fantasma(i);
     if(num!=0)
        var = var/num; /(277/3 = 92) - (92/4 = 23) - (23/1 =23) - (23/2=11)
     num = (num +1)%5; // 4, 0, 1, 2, 3
     //printf("*%d num*\n",num);
     //printf("**%d var**\n",var);
 }
return 0;
}
