#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    int soma,v1=1,v2=1;
    printf("%i, %i, ",v1,v2);
    for (int h=3; h<=30; h++)
    {
      soma=v1+v2;
      printf("%i, ", soma);
      v2=v1;
      v1=soma;
    }

    printf("\nFinalizando o programa...");

    return 0;
}