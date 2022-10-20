using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    public class Rotiseria
    {
        // Datos registrados
        private string[] userNames { get; set; }
        private List<float> puntuacion { get; set; }
        private List<float> ingresos { get; set; }
        private List<string> pedidos { get; set; }
        //Consumidores
        private int arrayCurrentIndex = 0;

        //Trabajadores
        private const int contraseña = 1234;

        public Rotiseria()
        {
            userNames = new string[10] { "Miguel", "", "", "", "", "", "", "", "", "" };
            puntuacion = new List<float>();
            ingresos = new List<float>();
            pedidos = new List<string>();
        }


        public void inicio()
        {
            Console.WriteLine("¡Bienvenidos a la Rotisería!" + "\n ¿En qué puedo ayudarle? \n Seleccione una opción ingresando su número correspondiente.\n 1) Realizar un pedido. \n 2) Abonar su pedido. \n 3) Opciones del personal de servicio.");
            int opcion = int.Parse(Console.ReadLine());
            string nombre;
            switch (opcion)
            {
                case 1:
                    if (arrayCurrentIndex < 10)
                    {
                        Console.WriteLine("Usted ha seleccionado 'Realizar un pedido'.\n Comencemos por registrar su nombre.");
                        nombre = Console.ReadLine();
                        nuevoUsuario(nombre);
                        hacerPedido();
                    }
                    else
                    {
                        Console.WriteLine("Lamentamos informarle que está en lista de espera, aguarde a ser llamado por el personal.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Usted ha seleccionado 'Abonar su pedido'.");
                    removerUsuario();
                    abonar();
                    puntuar();
                    break;
                case 3:
                    Console.WriteLine("Usted debe validar que sea un personal de servicio.\n Por favor, ingrese la contraseña.");
                    int contraseñaIngresada = int.Parse(Console.ReadLine());
                    if (contraseñaIngresada == contraseña)
                    {
                        datosEmpresa();
                    }
                    else
                    {
                        Console.WriteLine("Clave errónea. Volverá al inicio.");
                        inicio();
                    }
                    break;
            }
        }

        private void nuevoUsuario(string nombre)
        {
            userNames[arrayCurrentIndex] = nombre;
            Console.WriteLine("\n ¡Registro exitoso!" + $"\n El nombre registrado es {userNames[arrayCurrentIndex]}");
            arrayCurrentIndex++;
        }
        private void hacerPedido()
        {
            Console.WriteLine("Ingrese su pedido:");
            string pedido = Console.ReadLine();
            Console.WriteLine($"Usted a pedido: {pedido}.\n ¿Es correcto? [SI/NO]");
            string respuesta = Console.ReadLine();
            if (respuesta == "SI")
            {
                pedidos.Add(pedido);
                Console.WriteLine("¡Su pedido ha sido registrado con éxito! Aguarde a ser atendido");
            }
            else hacerPedido();

            inicio();

        }

        private void removerUsuario() { arrayCurrentIndex--; }

        private void abonar()
        {
            Console.WriteLine("Ingrese el monto a abonar: ");
            float ingreso = float.Parse(Console.ReadLine());
            ingresos.Add(ingreso);
            Console.WriteLine("¡Transacción extiosa!");

        }

        private void puntuar()
        {
            Console.WriteLine("Antes de terminar, ¡nos interesa tu opinión! Puntee su experiencia del 1 al 10.");
            float puntos = float.Parse(Console.ReadLine());
            puntuacion.Add(puntos);
            Console.WriteLine("Muchas gracias por su compra, ¡vuelva pronto!");
            inicio();
        }

        private void datosEmpresa()
        {
            Console.WriteLine("Seleccione una opción ingresando su número correspondiente.\n 1) Ver ingresos totales. \n 2) Ver puntuación total.");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine(totales(ingresos));
                    break;
                case 2:
                    Console.WriteLine(totales(puntuacion));
                    break;
            }
        }

        private float totales(List<float> datos)
        {
            float sumaTotal = 0;
            //for (int i = 0; i < datos.Count(); i++) ingresoTotal += datos[i];
            foreach (float item in datos)
            {
                sumaTotal += item;
            }
            return sumaTotal;
        }
    }
}
