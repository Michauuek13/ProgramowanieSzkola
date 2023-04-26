import random
import os

def showMenu():
    os.system('CLS')
    print("Funkcja kwadratowa")
    print("1.Rownosci")

    print("Wybierz opcje:")
    wybor =input("")
    print(wybor)

    if(wybor == "1"):
        rownosci(wybor)
        
    if(wybor == "2"):
        rownosci(wybor)
        return(wybor)

def rownosci(wybor):
    os.system('CLS')
    print("Oblicz delte dla funcji:")
    a = random.randint(-5, 0)
    b = random.randint(-10,0)
    c = random.randint(-30, 0)
    if(b<0):
        and1 = "- "
        b2 = b * -1
    else:
        and1= "+ "
        b2 = b
    
    if(c<0):
        and2 = "- "
        c2 = c * -1
    else:
        and2= "+ "
        c2 = c
    
    print(str(a) +"x² "+ str(and1) + str(b2) +"x " + str(and2) + str(c2))
    d = b * b - (4 * a * c)

    print("Console answer = " + str(d))

    print("Podaj delte:")
    answer = input()

    while(str(answer) != str(d)):
        print("Delta nie poprawna")
        print("Sproboj ponownie:")
        answer = input()
    if(a<0 and b<0 and c<0):
        dminus = d * -1
        print(str(dminus))
        if(str(answer) == str(dminus)):
            print("Delta jest poprawna")
    elif(str(answer) == str(d)):
            print("Delta poprawna")
    
    
    if(wybor == "2"):
        print("wybor " +str(wybor))
        MiejscaZ(a, b, c)
        return(int(a), int(b) ,int(c))

   
    def MiejscaZ():
        print(str(a) + str(b) + str(c))
        print("Oblicz X1")



showMenu()