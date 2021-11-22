#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    float p1, p2, media;
    printf("Digite  a nota da P1:");    
    scanf("%f",&p1); 
    printf("Digite  a nota da P2:");    
    scanf("%f",&p2);
    media=(p1+2*p2)/3;
    printf("Media: %.2f \n",media);
    if(media>=5)
    {
        printf("Aprovado"); 
    }   
    else
    {
        printf("Reprovado"); 
    }
    

   return 0;
} 
