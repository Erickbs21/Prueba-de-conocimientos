using System;
using System.Data;

namespace ProyectoBD
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Server=DARLA\\SQLEXPRESS;Database=PRUEBATEC;Trusted_Connection=True;TrustServerCertificate=True;";

            DBConexion conexion = new DBConexion(cadena);
            DBAcciones acciones = new DBAcciones(conexion);

            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("===== MENU BASE DE DATOS =====");
                Console.WriteLine("1. Mostrar proyectos");
                Console.WriteLine("2. Insertar proyecto");
                Console.WriteLine("3. Actualizar proyecto");
                Console.WriteLine("4. Eliminar proyecto");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        DataSet ds = conexion.EjecutarSelect("SELECT * FROM PROYECTO");

                        Console.WriteLine("\nID\tNOMBRE");
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            Console.WriteLine($"{row["IdProyecto"]}\t{row["Nombre"]}");
                        }

                        Logger.Escribir("SELECT en PROYECTO");
                        break;

                    case 2:
                        Console.Write("Nombre del proyecto: ");
                        string nombre = Console.ReadLine();

                        int insert = acciones.InsertarProyecto(nombre);
                        Console.WriteLine($"Filas insertadas: {insert}");
                        Logger.Escribir($"INSERT en PROYECTO (Nombre={nombre})");
                        break;

                    case 3:
                        Console.Write("ID del proyecto a actualizar: ");
                        int idUpdate = int.Parse(Console.ReadLine());

                        Console.Write("Nuevo nombre: ");
                        string nuevoNombre = Console.ReadLine();

                        int update = acciones.ActualizarProyecto(idUpdate, nuevoNombre);
                        Console.WriteLine($"Filas actualizadas: {update}");
                        Logger.Escribir($"UPDATE en PROYECTO (Id={idUpdate})");
                        break;

                    case 4:
                        Console.Write("ID del proyecto a eliminar: ");
                        int idDelete = int.Parse(Console.ReadLine());

                        int delete = acciones.EliminarProyecto(idDelete);
                        Console.WriteLine($"Filas eliminadas: {delete}");
                        Logger.Escribir($"DELETE en PROYECTO (Id={idDelete})");
                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }
    }
}
