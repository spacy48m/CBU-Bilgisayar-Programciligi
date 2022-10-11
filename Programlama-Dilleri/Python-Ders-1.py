a = 5
b = 6
if a >= b :
    print ("a > b")
else :
    print ("b > a\n")
a = 11
if a == 0 :
    print("a 0 dir")
elif 10 < a < 100 :
    print("a 10 dan buyuk 100 den kucuktur\n")
else :
    print("a 0 dan kucuktur")

sayi = 10
if 0 < sayi and sayi < 10 :
    print("rakam")
elif 0 <= sayi :
    print("pozitif tamsayi\n")
elif 0 >= sayi :
    print("negatif tamsayi")

sayi = int(input("Sayi gir: "))
if sayi > 0 and sayi%2 == 0:
    print(sayi*2)
else :
    if sayi < 0 and sayi % 2 == 1 :
         print(sayi*3)
    else :
         print(sayi**2)


