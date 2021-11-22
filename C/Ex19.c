#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    float v, v0, a, t;
    printf("Digite  a aceleracao em m/s2:");    
    scanf("%f",&a); 

    printf("Digite a velocidade inicial em m/s:");    
    scanf("%f",&v0);

    printf("Digite o tempo do percurso em s:");    
    scanf("%f",&t);

    v=v0+(a*t);
    printf("velocidade final: %.2f m/s \n",v);    

    if(v>60)
    {
      if(v>80)
      {
       if(v>120)
       {
         printf("Veiculo muito rapido");
       }
       else
       {
         printf("Veiculo rapido");  
       }
      }
      else
      {
          printf("Veiculo de cruzeiro");
      } 
    }
    else
    {
        if(v>40)
        {
           printf("Velocidade permitida");
        }
        else
        {
            printf("Veiculo muito lento");
        }
        
    }
    return 0;
}
