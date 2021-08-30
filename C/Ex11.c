#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    int a, b;
    printf("Digite o primeiro valor:");
    scanf("%i",&a);

    printf("Digite o segundo valor:");
    scanf("%i",&b);
    if(a>b)
    {
      printf("Maior valor: %i",a);
    }
    else
    {
     if(a==b)
      {
       printf("Identicos");
      }
      else
      {
       printf("Maior valor: %i",b);
      }
    }
    return 0;
}
