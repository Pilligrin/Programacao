#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    float p1, p2;
    printf("Digite  a nota da P1:");    
    scanf("%f",&p1); 
    
    p2=(15-p1)/2;
    printf("O Aluno precisa tirar: %.2f pontos para ser aprvado\n",p2);

    return 0;
}