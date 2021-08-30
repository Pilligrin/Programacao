#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    float a, b, c, maior, m1, m2;
    printf("Digite o valor 1:");
    scanf("%f",&a);

    printf("Digite o valor 2:");
    scanf("%f",&b);

    printf("Digite o valor 3:");
    scanf("%f",&c);
    if(a>b)
    {
      if(a>c)
        {
        maior=a;
        m1=c;
        }
      else
        {
        maior=c;
        m1=a;
        }
      m2=b;
    }
    else
    {
        if(b>c)
        {
        maior=b;
        m1=c;
        }
        else
        {
          maior=c;
          m1=b;
        }
        m2=a;
    }
    if((m1+m2)>maior)
    {
     if(a==b==c)
     {
      printf("Equilatero");
     }
     else
     {
         if(a==b||a==c||b==c)
         {
             printf("Isoceles");
         }
         else
         {
             printf("Escaleno");    
         }
     }
    }
    else{
     printf("nao forma triangulo");   
    }
    return 0;
}