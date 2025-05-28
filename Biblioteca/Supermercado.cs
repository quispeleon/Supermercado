using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotecaa
{
    public class Supermercado
    {
        private static List<Producto> productos = new List<Producto>();

        public static void Main ()
        {
    
            while(true)
            {
                Console.WriteLine("");
                Console.WriteLine("Si quiere dar de alta, ingrese 1");
                Console.WriteLine("Si quiere modificar un producto, ingrese 2");
                Console.WriteLine("Si quiere dar de baja un producto, ingrese 3");
                Console.WriteLine("Si quiere ver los productos, ingrese 4");
                Console.WriteLine("Si quiere salir, ingrese 0");
                Console.WriteLine();

                string opcion = Console.ReadLine().Trim();

                if (opcion == "0")
                    break;

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Necesito el nombre del producto");
                        string nombreAlta = Console.ReadLine().Trim();
                        Console.WriteLine("Necesito el precio del producto");
                        decimal precioUnitario = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Necesito la cantidad que hay del producto");
                        int cantidad = Convert.ToInt32(Console.ReadLine());

                        AltaProducto(nombreAlta, precioUnitario, cantidad);
                        break;

                    case "2":
                        Console.WriteLine("Necesito el nombre del producto: ");
                        string nombreMod = Console.ReadLine().Trim();

                        ModificarProducto(nombreMod);
                        break;

                    case "3":
                        Console.WriteLine("Necesito el nombre del producto.");
                        string nombreBaja = Console.ReadLine().Trim();

                        BajaProducto(nombreBaja);
                        break;

                    case "4":
                        MostrarProductos();
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
            }
            }        

            
        }

        static void AltaProducto(string nombre, decimal precio, int cantidad)
        {
            productos.Add(new Producto { Nombre = nombre, PrecioUnitario = precio, Cantidad = cantidad });
            Console.WriteLine("Producto agregado con éxito.");
        }


        static void ModificarProducto(string nombre)
        {
           var producto = productos.Find(p => p.Nombre.Trim().Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase));
           if (producto != null)
            {
                Console.WriteLine("Producto encontrado. Ingrese los nuevos datos :");

                Console.WriteLine("Ingrese nuevo nombre :");
                string nuevoNombre = Console.ReadLine();

                Console.WriteLine("Ingrese un nuevo precio :");
                decimal nuevoPrecio = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad del producto :");
                int nuevaCantidad = Convert.ToInt32(Console.ReadLine());

                producto.Nombre = nuevoNombre;
                producto.PrecioUnitario = nuevoPrecio;
                producto.Cantidad = nuevaCantidad;

                Console.WriteLine("Producto modificado exitosamente");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        static void BajaProducto(string nombre)
        {
           var producto = productos.Find(p => p.Nombre.Trim().Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase));
                if (producto != null)
                {
                productos.Remove(producto);
                Console.WriteLine("Producto eliminado.");
                }
                else
                {
                Console.WriteLine("Producto no encontrado.");
                }
        }

        static void MostrarProductos() {
            foreach (var producto in productos)
            {
                Console.WriteLine(producto.Nombre + " - " + producto.PrecioUnitario); 
                Console.WriteLine();
            }
        }

    }
}