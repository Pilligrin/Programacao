#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    int soma;
    for (int h=1; h<=100; h++)
    {
      soma=h+soma;
      if(h>=100)//Coloquei maior igual, porque quando colocava só igual a soma dava 1
      {
         printf("Soma dos numeros inteiros de 1 a 100: %i", soma);
      }
    }

    printf("\n Finalizando o programa...");

    return 0;
}