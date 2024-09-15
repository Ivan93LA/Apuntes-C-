using System;

namespace CSharpHelloWorld {

    class HelloWorld
    {
        static void Main(string[] args)
        { 
            // Ejemplo de un comentario
            Console.WriteLine("Hola mi mundo con el lenguaje C#");
            /*
             Ejemplo para comentar varios
             tipos de linea
            */

            string myString = "Ejemplo de una cadena de texto";
            myString = "He ejecutado un cambio en la cadena";
            //Imprime el segundo string, no el primero
            Console.WriteLine(myString);

            int myInt = 2;
            myInt = myInt + 1;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1);
            Console.WriteLine(myInt);

            float myFlotat = 6.8f;
            //Para definir el decimal, SI o SI tenemos que poner el "f"
             Console.WriteLine(myFlotat);

            //Pero si lo defines como double, si lo reconoce
            double myDouble = 6.8;
            Console.WriteLine(myDouble);





        }
    }

    



}


