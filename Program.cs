using System;

namespace classes
{
    class Program
    {
        //Desarrollado por Sergio Sabino, matricula 2019-8675
        static void Main(string[] args)
        {
            //1. Programa que pida al ususario un numero entero y diga si es par
            // Console.WriteLine("Ingrese un numero");
            // int numero = Convert.ToInt32(Console.ReadLine());

            // if(numero % 2 == 0){
            // Console.WriteLine("El numero es par!");

            // }else{
            // Console.WriteLine("El numero no es par!");
            // }

            //2. Programa que pida 2 numeros enteros y diga cual es mayor.
            // Console.WriteLine("Ingrese un numero");
            // int num = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese otro numero");
            // int num2 = Convert.ToInt32(Console.ReadLine());

            // if (num > num2)
            // {
            //     Console.WriteLine("El primer numero es mayor que el segundo!");
            // }
            // else if (num2 > num)
            // {
            //     Console.WriteLine("El segundo numero es mayor que el primero!");

            // }
            // else
            // {
            //     Console.WriteLine("Son iguales!");

            // }

            //3. Programa que pida dos numeros enteros y diga si el primero es multiplo
            //del segundo
            // Console.WriteLine("Ingrese un numero");
            // int num = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese otro numero");
            // int num2 = Convert.ToInt32(Console.ReadLine());

            // if (num % num2 == 0)
            // {
            //     Console.WriteLine("El primero es multiplo del segundo!");
            // }
            // else
            // {
            //     Console.WriteLine("El primero es no multiplo del segundo!");

            // }

            /*4.
            Crear un programa que pida al usuario un número entero. Si es múltiplo de 10,
            se lo avisará al usuario y pedirá un segundo número, para decir a continuación
            si este segundo número también es múltiplo de 10.
            */
            // Console.WriteLine("Ingrese un numero");
            // int num = Convert.ToInt32(Console.ReadLine());


            // if (num % 10 == 0)
            // {
            //     Console.WriteLine("El primero es multiplo de 10!");
            //     Console.WriteLine("Ingrese otro numero");
            //     int num2 = Convert.ToInt32(Console.ReadLine());
            //     if (num2 % 10 == 0)
            //     {
            //         Console.WriteLine("El segundo es multiplo de 10!");
            //     }
            //     else
            //     {
            //         Console.WriteLine("El segundo no es multiplo de 10!");
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("El primero no es multiplo de 10!");
            // }

            /*5
            Crear un programa que multiplique dos números enteros de la siguiente forma:
            pedirá al usuario un primer número entero. Si el número que se que teclee es 0,
            escribirá en pantalla &quot;El producto de 0 por cualquier número es 0&quot;. Si se ha
            tecleado un número distinto de cero, se pedirá al usuario un segundo número y
            se mostrará el producto de ambos.
            */

            // Console.WriteLine("Ingrese un numero");
            // int num = Convert.ToInt32(Console.ReadLine());

            // if (num != 0)
            // {
            //     Console.WriteLine("Ingrese otro numero");
            //     int num2 = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("ILa producto de " + num.ToString() + " * " + num2.ToString() + " Es Igual a: " + (num * num2).ToString());
            // }
            // else
            // {
            //     Console.WriteLine("El producto de 0 por cualquier número es 0!");
            // }

            /*6
            Crear un programa que pida al usuario dos números enteros. Si el segundo no
            es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el
            contrario, si el segundo número es cero, escribirá Error: No se puede dividir
            entre cero;.
            */
            // Console.WriteLine("Ingrese un numero");
            // int num = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese otro numero");
            // int num2 = Convert.ToInt32(Console.ReadLine());

            // if (num2 == 0)
            // {
            //     Console.WriteLine("Error: No se puede dividir entre cero.");
            // }
            // else
            // {
            //     Console.WriteLine("El resultado es: " + (num / num2).ToString());

            // }

            //7. Crear un programa que pida al usuario un numero entero y diga si es
            //multiplo de 4  de 5.

            //     Console.WriteLine("Ingrese un numero");
            //     int num = Convert.ToInt32(Console.ReadLine());

            //     if (num % 4 == 0 && num % 5 == 0)
            //     {
            //         Console.WriteLine("El numero es multiplo de 4 y 5");
            //     }
            //     else if (num % 4 == 0)
            //     {
            //         Console.WriteLine("El numero es multiplo de 4");
            //     }
            //     else if (num % 5 == 0)
            //     {
            //         Console.WriteLine("El numero es multiplo de 5");
            //     }
            //     else
            //     {
            //         Console.WriteLine("El numero no es multiplo de 4 y 5");
            //     }


            /* 8.
            Crear un programa que pida al usuario dos números enteros y diga Uno de los
            números es positivo, Los dos números son positivos o bien Ninguno de los
            números es positivo, según corresponda.
            */

            // Console.WriteLine("Ingrese un numero");
            // int num = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese otro numero");
            // int num2 = Convert.ToInt32(Console.ReadLine());

            // if (num > 0 && num2 > 0)
            // {
            //     Console.WriteLine("Los dos números son positivos!");
            // }
            // else if(num > 0 || num2 > 0)
            // {
            //     Console.WriteLine(" Uno de los números es positivo");

            // }else if(num < 0 || num2 < 0){
            //     Console.WriteLine(" Ninguno de los números es positivo");

            // }

            //9. Crear un programa que pida al usuario 3 numeros reales y 
            // muestre cual es el mayor de los 3

            Console.WriteLine("Ingrese un numero");
            float num = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            float num3 = float.Parse(Console.ReadLine());

            if (num > num2 && num > num3)
            {
                Console.WriteLine(num.ToString() + " es el mayor");
            }
            else if (num2 > num && num2 > num3)
            {
                Console.WriteLine(num2.ToString() + " es el mayor");
            }
            else if (num3 > num2 && num3 > num)
            {
                Console.WriteLine(num3.ToString() + " es el mayor");
            }

        }

    }
}
