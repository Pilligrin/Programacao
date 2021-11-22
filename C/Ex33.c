#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    printf("Digite os numeros: ");
    int numeros[10];

    for (int i=0; i<10; i++)
    {
    scanf("%i",&numeros[i]);
    }

     for (int i=0; i<10; i++)
      {  
       printf("%i, ", numeros[i]);
     }

    printf("\n Finalizando o programa...");

    return 0;
}