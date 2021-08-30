#include <stdio.h>
#include <stdlib.h>


int main(int argc, char const *argv[])
{
    int lado, area;
    printf("Digite o lado do quadrado: ");
    scanf("%i",&lado);

    area= lado*lado;

    printf("A area do quadrado e: %i",area);

    return 0;
}
