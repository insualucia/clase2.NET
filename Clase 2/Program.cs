
using Clase_2;
using System;
using System.Collections.Generic;

public class Class1
{

    static void Main(string[] args)
    {
        Rotiseria rotiseria = new Rotiseria();
        rotiseria.inicio();
    }

}



/* --------------- NOTAS DE LA CLASE *IGNORAR* ------------------- */

/*
 
 NAMESPACE = Contiene todos los elementos relacionados
CLASES ? 
 
 */

//LISTAS

//using System.Collections.Generic;
//namespace Clase2 
//{
//class Program
//{
//    static void Main(string[] args)
//    {
//        List<string> Ropa = new List<string>();
//        Ropa.Add("Remera");

//        Console.WriteLine(Ropa[0]);
//    }
//}

//    public class Rostiseria
//    {
//        static void Main(string[] arg)
//        {
//            string[] userName = new string[10] { "Migue", "", "", "", "", "", "","","",""};
//            int arrayCurrentIndex = 0;
//            bool userType;

//            Console.WriteLine("Rostiseria, ¡bienvenido!");


//            while(arrayCurrentIndex < 10)
//            {
//                Console.WriteLine("\n ¿Está en el sistema? Responda True/False.");
//                userType = bool.Parse(Console.ReadLine());

//                if(userType == true) 
//                {
//                    Console.WriteLine("\n Joya! Ingrese su nombre por favor.");
//                    string userToSearch = Console.ReadLine();

//                    Console.WriteLine($"El usuario ingresado es {userToSearch}");
//                    int index = Array.IndexOf(userName, userToSearch); //compara elementos y si existe en la lista devuelve el indice, sino -1

//                    if (index == -1)
//                    {
//                        Console.WriteLine("Usuario no encontrado.");
//                    }
//                    else
//                    {
//                        Console.WriteLine($"Hola, {userName[index]}. ¿Puedo tamer su pedido?");
//                    }
//                }else if(userType == false)
//                {
//                    Console.WriteLine("\n Por favor, ingrese su nombre para registrarse.");
//                    userName[arrayCurrentIndex] = Console.ReadLine();
//                    Console.WriteLine("\n ¡Registro exitoso!" +$"\n El usuario registrado es {userName[arrayCurrentIndex]}");
//                    arrayCurrentIndex++;
//                }

//            }
//            Console.WriteLine("El restaurante está lleno! La lista de reserva es: \n");
//            int auxiliarIndex = 0;
//            foreach (string item in userName)
//            {
//                Console.WriteLine($"Usuario numero {auxiliarIndex + 1} y el nombre de usuario es: ${userName[auxiliarIndex]}");
//                auxiliarIndex++;
//            }
//            Console.WriteLine("¡Gracias por elegirnos!");
//            Environment.Exit(0);
//        }
//    }
//}

