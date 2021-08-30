#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    float Fahrenheit, Celsius;
    printf("Digite a temperatura em Fahrenheit: ");
    scanf("%f",&Fahrenheit);

    Celsius=((Fahrenheit-32)/(1.8));
    printf("A temperatura em Celsius deu %.2f",Celsius);
    return 0;
}