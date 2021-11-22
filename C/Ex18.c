#include<stdlib.h>
#include<stdio.h>

int main(int argc, char const *argv[])
{
    float peso, altura, imc;
    char sexo;
    printf("OBS: Digite m para masculino ou f para feminino");
    printf("\nDigite o sexo:");    
    scanf("%c",&sexo);

    printf("Digite o peso:");
    scanf("%f",&peso);

    printf("Digite a altura:");
    scanf("%f",&altura);
    
    imc=peso/(altura*altura);
    

    if (sexo=='m')
    {
        if (imc>25)
        {
            printf("Acima do peso");
        }
        else
            {
             if (imc<20)
             {
                printf("Abaixo do peso");
             }
             else
             {
                printf("Peso Ideal");
             }   
            }
    }
   if (sexo=='f')
    {
        if (imc>24)
        {
            printf("Acima do peso");
        }
        else
            {
             if (imc<19)
             {
                printf("Abaixo do peso");
             }
             else
             {
                printf("Peso Ideal");
             }   
            }
    }
    
    return 0;
}
