#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    int soma,v1=1,v2=1, v3=1, h=4;
    printf("%i, %i, %i, ",v1,v2, v3);
    while (h<=20)
    {
      soma=v1+v2+v3;
      printf("%i, ", soma);
      v3=v2;
      v2=v1;
      v1=soma;
      h++;
    }

    printf("\nFinalizando o programa...");

    return 0;
}