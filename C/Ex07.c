#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    float p1, p2, p3, p4, p5, pagar, troco;
    printf("Valor do produto 1: ");
    scanf("%f",&p1);

    printf("Valor do produto 2: ");
    scanf("%f",&p2);

    printf("Valor do produto 3: ");
    scanf("%f",&p3);

    printf("Valor do produto 4: ");
    scanf("%f",&p4);

    printf("Valor do produto 5: ");
    scanf("%f",&p5);

    printf("Pagamento: ");
    scanf("%f",&pagar);

    troco=pagar-p1-p2-p3-p4-p5;
    printf("Troco: %.2f",troco);
    return 0;
}
