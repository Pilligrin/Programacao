#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    int valor=0, i=1, r;
    while (valor<=0)
    {
     printf("Digite  um valor positivo: ");    
     scanf("%i",&valor); 
    }
    while (i<=10)
    {
     r=valor*i;
     printf("%i x %i = %i \n",valor, i, r);
     i++;
    }


    printf("Finalizando o programa...");

    return 0;
}