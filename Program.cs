using System;
using System.Collections.Generic;

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

            float myFloat = 6.8f;
            //Para definir el decimal, SI o SI tenemos que poner el "f"
            Console.WriteLine(myFloat);

            //Pero si lo defines como double, si lo reconoce
            double myDouble = 6.8;
            Console.WriteLine(myDouble);

            Console.WriteLine(myInt + myFloat + myDouble);

            dynamic myDynamic = 6;
            myDynamic = "Mi dato dinamico";
            Console.WriteLine(myDynamic);

            //ESTRUCTURAS
            //Los arrays tienen una longitud fija ni tampoco cambiarles el tipo
            var myArray = new string[] { "Ivan", "Leon", "Alvarez" };
            Console.WriteLine(myArray[0]);


            myArray[2] = "31";
            Console.WriteLine(myArray[2]);


            var myDiccionario = new Dictionary<string, int>
            { 
                { "Ivan" , 31},
                { "Paula" , 25}

             };

            Console.WriteLine(myDiccionario["Paula"]);

            
            



        }
    }


}


