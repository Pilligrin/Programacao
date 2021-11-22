#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
    int num=1,r;

    while (num<=10)
    {
     r=5*num;
     printf("5 x %i = %i \n",num, r);
     num++;
    }

    printf("Finalizando o programa...");

    return 0;
}