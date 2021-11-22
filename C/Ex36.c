#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    printf("Digite os numeros: ");
    int numeros[20], k, valores[20];

    for (int i=0; i<20; i++)
    {
    scanf("%i",&numeros[i]);
    }
     printf("Digite a constante: ");
     scanf("%i",&k);   

     for (int i=0; i<20; i++)
      {  
       valores[i]=numeros[i]*k;   
       printf("%i, ", valores[i]);
     }

    printf("\n Finalizando o programa...");

    return 0;
}