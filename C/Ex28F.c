#include <stdio.h>
#include <stdlib.h>  
#include<conio.h>

int main(int argc, char const *argv[])
{
    int r, h, i;
    for(h=1;h<21;h++)
    {
        for(i=1;i<11;i++)
        {
            r=h*i;
            printf("\n%i x %i = %i",h,i,r);
        }
        getch();
    }
    return 0;
}

    

