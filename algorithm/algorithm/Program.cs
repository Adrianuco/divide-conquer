namespace algorithm
{
    internal class Program
    {
        static void BusquedaBinaria(int[] array, int num)
        {
            int izquierda = 0;
            int derecha = array.Length - 1;
            int medio;

            //Bucle para realizar la búsqueda binaria
            while (izquierda <= derecha)
            {
                //Calcular la posición media del array
                medio = (izquierda + derecha) / 2;

                //Si el número en la posición media es el buscado
                if (array[medio] == num)
                {
                    Console.WriteLine("");
                    Console.WriteLine("El número {0} se encuentra en la posición {1}", num, medio);
                    return;
                }

                //Si el número en la posición media es menor, buscar en la mitad derecha
                else if (array[medio] < num)
                {
                    izquierda = medio + 1;
                }

                //Si el número en la posición media es mayor, buscar en la mitad izquierda
                else
                {
                    derecha = medio - 1;
                }
            }
            //Si el número no se encuentra en el "arreglo"
            Console.WriteLine("");
            Console.WriteLine("El número {0} no se encuentra en el arreglo", num);
        }
        static void Main(string[] args)
        {
            //Definimos el "arreglo" y debe estar ordenado para la búsqueda binaria
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            //Solicitamos el número que se buscara
            Console.Write("Introduce el número que deseas buscar: ");
            int num = int.Parse(Console.ReadLine());

            //Llamamos al "void" de Busqueda Binaria
            BusquedaBinaria(array, num);

            Console.ReadKey();
        }
    }
}
