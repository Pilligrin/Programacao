j=1
v1=1
v2=1
v3=1
print(f' {v1} {v2} ')

for j in range(1, 29, 1): 
   v3=v2+v1
   v1 = v2
   v2=v3
   j=j+1
   print(f' {v3} ')
