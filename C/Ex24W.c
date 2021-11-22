#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    char sexo;


    while (1)
    {
     printf("Digite  o sexo como F (feminino) ou M (masculino): ");    
     scanf("%s",&sexo);
     if((sexo=='M')||(sexo=='F'))
      {
        break;
      }
    }

    printf("Finalizando o programa...");

    return 0;
}