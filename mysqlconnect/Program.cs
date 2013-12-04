using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace mysqlconnect
{
    class Program
    {
        static void Main(string[] args)
        {

            Registro registros = new Registro();
            string opcionUsuario = "";
           
            do{


            Console.WriteLine("Elije una acción qué realizar a la base de datos: \n1-Mostrar información \n2-Editar registro \n3-Eliminar registro \n4-Nuevo registro \n5-Salir");
           
            opcionUsuario = Console.ReadLine();
            if (opcionUsuario == "1")
            {
                registros.MostrarRegistros();

            }
            else if (opcionUsuario == "2")
            {
                  registros.EditarCodigoRegistro();
                  registros.EditarNombreRegistro();
                  registros.EditarTelefonoRegistro();
                  registros.EditarEmailRegistro();
                  Console.WriteLine("Registro editado");
            }
           
            else if (opcionUsuario == "3")
            {
                
                registros.eliminarRegitro();
                Console.WriteLine("Registro eliminado");
            }
            else if (opcionUsuario == "4")
            {
                registros.NuevoRegistro();
                Console.WriteLine("Registro agregado");
            }

                Console.ReadKey();
                Console.Clear();

            }while(opcionUsuario != "5");  
                
            
            
        }
    }
}
