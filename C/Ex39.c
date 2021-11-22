#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    printf("Digite os numeros: ");
    int numeros[3][4], k;

    for (int i=0; i<3; i++)
    {
        for(int j=0; j<4; j++)
        {
          scanf("%i",&numeros[i][j]);
        }
    }

    printf("Digite a contante: ");
    scanf("%i",&k);

    for (int i=0; i<3; i++)
    {
        for(int j=0; j<4; j++)
        {
          numeros[i][j]=k*numeros[i][j];
          printf("%i\n",numeros[i][j]);
        }
    }
    return 0;
}