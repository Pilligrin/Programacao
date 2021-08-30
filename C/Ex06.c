#include <stdlib.h>
#include <stdio.h>

int main(int argc, char const *argv[])
{
    float cotacao, dolar, real;
    printf("Digite a cotacao do dolar (US): ");
    scanf("%f",&cotacao);
    printf("Digite a quantidade de dolares (US): ");
    scanf("%f",&dolar);
    real=cotacao*dolar;
    printf("A quantia em real (BR): %.2f",real);
    return 0;
}


