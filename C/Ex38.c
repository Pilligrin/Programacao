#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    printf("Digite os numeros: ");
    int numeros[2][3];

    for (int i=0; i<2; i++)
    {
        for(int j=0; j<3; j++)
        {
          scanf("%i",&numeros[i][j]);
        }
    }

    for (int i=0; i<2; i++)
    {
        for(int j=0; j<3; j++)
        {
          printf("%i\n",numeros[i][j]);
        }
    }
 
 


    printf("\n Finalizando o programa...");

    return 0;
}