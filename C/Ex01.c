#include <stdio.h>
#include <stdlib.h>


int main(int argc, char const *argv[])
{
    int altura, base, area;
    printf("Digite a altura do retangulo: ");
    scanf("%i",&altura);

    printf("Digite a base do retangulo: ");
    scanf("%i",&base);

    area= altura*base;

    printf("A area do retangulo e: %i",area);

    return 0;
}
