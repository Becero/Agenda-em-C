#include<stdio.h>
#include<stdlib.h>
int main(){
int *p;
p = (int *) malloc(sizeof(int));
if(p == NULL){
printf("Nao foi possivel alocar memoria. \n");
exit(0);
}
printf("%d",p);
*p = 5;
//printf("%d\n", *p);
free(p);
return 0;
}
