#include <stdlib.h>
#include <stdio.h>

int main(int argc, char const *argv[])
{
    float peso, altura, imc;

    printf("Digite o peso: ");
    scanf("%f",&peso);

    printf("Digite a altura: ");
    scanf("%f",&altura);

    imc=peso/(altura*altura);
    printf("IMC deu %.2f",imc);
    return 0;
}
