#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    int soma, h=1;
    while (h<=100)
    {

      soma=h+soma;
      
      if(h==100)
      {
         printf("Soma dos numeros inteiros de 1 a 100: %i", soma);
      }
      h++;
    }

    printf("\n Finalizando o programa...");

    return 0;
}