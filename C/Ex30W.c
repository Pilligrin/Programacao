#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    int soma,v1=1,v2=1, h=3;
    printf("%i, %i, ",v1,v2);
    while (h<=30)
    {
      soma=v1+v2;
      printf("%i, ", soma);
      v2=v1;
      v1=soma;
      h++;
    }

    printf("\nFinalizando o programa...");

    return 0;
}