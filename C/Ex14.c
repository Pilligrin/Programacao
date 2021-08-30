#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    float a, b, c;
    printf("Digite o valor 1:");
    scanf("%f",&a);

    printf("Digite o valor 2:");
    scanf("%f",&b);

    printf("Digite o valor 3:");
    scanf("%f",&c);
    printf("Maior: ");
    if(a>b)
    {
      if(a>c)
        {
        printf("%.2f",a);
        }
      else
        {
        printf("%.2f",c);
        }
    }
    else
    {
        if(b>c)
        {
        printf("%.2f",b);
        }
        else
        {
          printf("%.2f",c);
        }
    }
    return 0;
}
