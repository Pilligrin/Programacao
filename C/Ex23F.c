#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    float v1, v2;

    printf("Digite  um valor 1: ");    
    scanf("%f",&v1);

    for(int i=0; i<2; i++)
    {
     i=0;//serve para resetar
     printf("Digite  um valor 2, que seja maior que valor 1: ");    
     scanf("%f",&v2);
     if(v2>v1)
      {
        break;
      }
    }

    printf("Finalizando o programa...");

    return 0;
}