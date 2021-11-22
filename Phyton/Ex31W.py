j=1
v1=1
v2=1
v3=1
v4=1
print(f' {v1} {v2} {v3}')

while(j<=17): 
   v4=v3+v2+v1
   v1 = v2
   v2=v3
   v3=v4
   j=j+1
   print(f' {v4} ')

    