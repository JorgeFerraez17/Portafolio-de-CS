import os #libreria para borrar la consola
while True:
 a = 0
 a = input()
 os.system('cls') # comando para borrar la consola 
 num3 = 0

 nun1 = int(input("Escribe el primer numero entero\n"))

 nun2 = int(input("Escribe el segundo numero entero\n"))

 x = int(input("Que operacion desea hacer\n1) Sumar\n2) Restar\n3) Multiplicar\n4) Dividir\n\n0) Salir\n"))

 #-------------------------------------------

 if (x == 0):
    break

 #--------------------------------------------

 elif (x == 1):
    os.system('cls')
    num3 = int(nun1 + nun2)

    print("El resultado de la suma entre ", nun1, " + ", nun2, " es :", num3) 
    

 #----------------------------------------------

 elif (x == 2):
    os.system('cls')
    num3 = (nun1 - nun2)

    print("El resultado de la resta entre ", nun1, " - ", nun2, " es :", num3)

 #------------------------------------------------

 elif (x == 3):
    os.system('cls')
    num3 = (nun1 * nun2)

    print("El resultado de la Multiplicacion entre ", nun1, " x ", nun2, " es :", num3)
 #-------------------------------------------------
 elif (x == 4):
     os.system('cls')
     num3 = (nun1 / nun2)

     print("El resultado de la Divicion entre ", nun1, "/", nun2, " es :", num3)
     

