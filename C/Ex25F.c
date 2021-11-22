#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    int r;

    for (int num=1; num<=10; num++)
    {
     r=5*num;
     printf("5 x %i = %i \n",num, r);
    }

    printf("Finalizando o programa...");

    return 0;
}