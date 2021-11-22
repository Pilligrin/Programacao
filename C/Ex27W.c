#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    int x, A, B, r;
    while(1)
    {
     printf("Digite  um valor positivo: ");    
     scanf("%i",&x);
     if(x>0) 
     {
       break;
     }
    }

    while(1)
    {
     printf("Digite  o inicio da tabuada, maior que zero: ");    
     scanf("%i",&A);
     if(A>0) 
     {
       break;
     }
    }

    while(1)
    {
     printf("Digite  o final da tabuada, maior que o inicio: ");    
     scanf("%i",&B);
     if(B>A) 
     {
       break;
     }
    }

    while (A<=B)
    {
     r=x*A;
     printf("%i x %i = %i \n",x, A, r);
     A++;
    }

    printf("Finalizando o programa...");
    return 0;
}