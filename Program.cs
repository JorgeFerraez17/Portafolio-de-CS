using Opera;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true){
            Console.WriteLine("Hola -Bienvenido a Calculadora- \n¿Que Operacion desea hacer?\n\n1)Suma\n2)Resta\n3)Divicion\n4)Multiplicacion\n\n0) Salir");
            var a = Console.ReadLine();
            int num1 = Int32.Parse(a);

            if (num1 == 0){
                Console.WriteLine("\n\nGracias, adios, nos vemos luego_____________:)\n");
                break;
            }

            else if (num1 == 1){

                Console.WriteLine("\nHola deme el primer numero");
                var b = Console.ReadLine();
                int num2 = Int32.Parse(b);
                Console.WriteLine("Hola deme el Segundo numero");
                var c = Console.ReadLine();
                int num3 = Int32.Parse(c);

                 var poo = new Suma ();
                 poo.Num10 = num2;
                 poo.Num11 = num3;

                poo.Operacion1();

                Console.WriteLine("\nEl Resultado de su suma es :" + poo.Rent + "  -----------------\n");
            }

            
            else if (num1 == 2){

                Console.WriteLine("\nHola deme el primer numero");
                var b = Console.ReadLine();
                int num2 = Int32.Parse(b);
                Console.WriteLine("Hola deme el Segundo numero");
                var c = Console.ReadLine();
                int num3 = Int32.Parse(c);

                 var poo = new Resta ();
                 poo.Num10 = num2;
                 poo.Num11 = num3;

                poo.Operacion2();

                Console.WriteLine("\nEl Resultado de su Resta es :" + poo.Rent + "  -----------------\n");
            }

            
            else if (num1 == 3){

                Console.WriteLine("\nHola deme el primer numero");
                var b = Console.ReadLine();
                int num2 = Int32.Parse(b);
                Console.WriteLine("Hola deme el Segundo numero");
                var c = Console.ReadLine();
                int num3 = Int32.Parse(c);

                 var poo = new Divi ();
                 poo.Num10 = num2;
                 poo.Num11 = num3;

                poo.Operacion3();

                Console.WriteLine("\nEl Resultado de su Divicion es :" + poo.Rent + "  -----------------\n");
            }

            
            else if (num1 == 4){

                Console.WriteLine("\nHola deme el primer numero");
                var b = Console.ReadLine();
                int num2 = Int32.Parse(b);
                Console.WriteLine("Hola deme el Segundo numero");
                var c = Console.ReadLine();
                int num3 = Int32.Parse(c);

                 var poo = new Multi ();
                 poo.Num10 = num2;
                 poo.Num11 = num3;

                poo.Operacion4();

                Console.WriteLine("\nEl Resultado de su Multiplicacion es :" + poo.Rent + "  -----------------\n");
            }



        }
    }
}