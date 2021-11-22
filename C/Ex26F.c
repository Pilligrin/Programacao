#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    int valor, r;
    for (int h=0; h<2; h++)
    {
     h=0;//reiniciar
     printf("Digite  um valor positivo: ");    
     scanf("%i",&valor);
     if(valor>0) 
     {
       break;
     }
    }
    for (int i=1;i<=10;i++)
    {
     r=valor*i;
     printf("%i x %i = %i \n",valor, i, r);
    }


    printf("Finalizando o programa...");

    return 0;
}