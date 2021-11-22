#include <stdio.h>
#include <stdlib.h>  
#include<conio.h>

int main(int argc, char const *argv[])
{
    int i=1, h=1, r;
    while(h<21)
    {
        while(i<11)
        {
            r=h*i;
            printf("\n%i x %i = %i",h,i,r);
            i++;
        }
     getch();
     h++;
    }
    
    return 0;
}

    
 
