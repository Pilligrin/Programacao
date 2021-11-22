#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    int numeros[3][4], l1=0, l2=0, numero, contagem, repete;

    while(1)
    {
    printf("Digite o numero de linhas, menor que 10 e maior que 0: ");
    scanf("%i",&l1);
    if((l1>0)&&(l1<10))
    {
        break;
    }
    }
    while(1)
    {
    printf("Digite o numero de colunas, menor que 10 e maior que 0: ");
    scanf("%i",&l2);
    if((l2>0)&&(l2<10))
    {
        break;
    }
    }

    for (int m=0; m<l1; m++)
    {
        for(int n=0; n<l2; n++)
        {
          scanf("%i",&numeros[m][n]);
        }
    }
    while(1)
    {
     printf("Digite um numero para o programa encontrar a posicao: ");
     scanf("%i",&numero);   

     for (int i=0; i<l1; i++)
      {  
          for(int j=0; j<l2; j++)
          { 

             if(numero==numeros[i][j])
            {
             printf("Posicao, linha: %i coluna: %i\n",i, j);
             contagem=1;
            }
          }
     }
     
     
     if(contagem==0)
     {
        printf("Valor nao encontrado!");
        printf("\nDeseja buscar novamente?");
        printf("\nDigite 1 para nao e 0 para sim:  ");
        scanf("%i",&repete);
     }

     if(repete==1)
     {
     break;
     }
    }
     
    return 0;
}