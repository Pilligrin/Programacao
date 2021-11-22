#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    int soma,lim, v1=2, v2=3, h=1;
    
    while (1)
    {
    printf("Digite o valor do limite da soma, menor que 100: ");
    scanf("%i",&lim);
    if((lim<100)&&(lim>0))
    {
        break;
    }
    }

    printf("%i, ", v1);
    
    if(lim>=2)
    {
     while (h<=lim)
      {
       soma=v1+v2;   
       printf("%i, ", soma);
       v2=v2+2;
       v1 =soma;
       h++;

     }
    }
    printf("\n Finalizando o programa...");

    return 0;
}