from typing import TYPE_CHECKING, type_check_only
import typing

i=1
j=1

while(j<=20): 
 while (i<=10):
   r =  j*i
   print(f'{j} X {i} = {r}')
   i=i+1
 TYPE_CHECKING.real('2')#trocar aqui por detector de enter
 j=j+1

