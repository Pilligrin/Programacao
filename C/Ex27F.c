#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    int x, A, B, r;
    for (int h=0; h<2; h++)
    {
     h=0;//reiniciar
     printf("Digite  um valor positivo: ");    
     scanf("%i",&x);
     if(x>0) 
     {
       break;
     }
    }

    for (int j=0; j<2; j++)
    {
     j=0;//reiniciar
     printf("Digite  o inicio da tabuada, maior que zero: ");    
     scanf("%i",&A);
     if(A>0) 
     {
       break;
     }
    }

    for (int k=0; k<2; k++)
    {
     k=0;//reiniciar
     printf("Digite  o final da tabuada, maior que o inicio: ");    
     scanf("%i",&B);
     if(B>A) 
     {
       break;
     }
    }

    for (int i=A;i<=B;i++)
    {
     r=x*i;
     printf("%i x %i = %i \n",x, i, r);

    }
    
    printf("Finalizando o programa...");

    return 0;
}