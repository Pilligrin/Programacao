#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    printf("Digite os numeros: ");
    int numeros[10], maior;

    for (int i=0; i<10; i++)
    {
    scanf("%i",&numeros[i]);
    }
     maior=numeros[1];//atribuido para o teste

     for (int i=0; i<10; i++)
      {  
       if(numeros[i]>maior)
       {
         maior=numeros[i];
       }
     }
       printf("Maior digitado: %i ", maior);
    printf("\n Finalizando o programa...");

    return 0;
}