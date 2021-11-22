#include<stdio.h>
#include<stdlib.h>

int main(int argc, char const *argv[])
{
    float c1, c2, h, sc;

    printf("Digite o cateto 1:");
    scanf("%f",&c1);

    printf("Digite o cateto 2:");
    scanf("%f",&c2);

    printf("Digite a hipotenusa:");
    scanf("%f",&h);

    sc=(c1*c1)+(c2*c2);//só está servindo para auxiliar, significa soma dos catetos ao quadrado

    if(sc==(h*h))
    {
        printf("Triangulo retangulo");
    }
    else
    {
        printf("Nao triangulo retangulo");
    }
    return 0;
}
