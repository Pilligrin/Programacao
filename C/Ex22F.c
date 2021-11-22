#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{  
    int valor;
    
    for(int i=0;i<2;i++)
    {
     i=0;
     printf("Digite  um valor positivo: ");    
     scanf("%i",&valor); 
     if(valor>0)
      {
        break;
      }
    }
    printf("Finalizando o programa...");

    return 0;
}