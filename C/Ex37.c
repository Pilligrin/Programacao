#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    printf("Digite a quantia, sendo maior que 0 e menor que 20: ");
    int numeros[20], numero, quantia, contagem=0, repete;

    scanf("%i",&quantia);
    if((quantia<=0)||(quantia>20))
    {
        while((quantia)<=0||(quantia>20))
        {
            printf("Erro, digite um numero maior que 0 e menor que 20: ");
            scanf("%i",&quantia);
        }
    }
   
    for (int i=0; i<quantia; i++)
    {
    scanf("%i",&numeros[i]);
    }
    while(repete==0)
    {
     printf("Digite um numero para o programa encontrar a posicao: ");
     scanf("%i",&numero);   

     for (int i=0; i<quantia; i++)
      {  
       if(numero==numeros[i])
       {
            printf("Posicao: %i\n",i);
            contagem=1;
       }
     }
     
     
    if(contagem==0)
    {
        printf("Valor nao encontrado!");
        printf("Digite 0 para repitir ou 1 para não repitir o número para encontrar: ");
     scanf("%i",&repete);
    }
     
    }
    printf("\n Finalizando o programa...");

    return 0;
}