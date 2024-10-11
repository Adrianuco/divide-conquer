namespace algorithm
{
    internal class Program
    {
        static void Main()
        {
            int[] numeros = new int[7];

            Console.WriteLine("---Lectura de Datos---");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese un número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("---Merge Sort---");
            Console.WriteLine("Array original:");
            MostrarArray(numeros);

            MergeSort(numeros, 0, numeros.Length - 1);

            Console.WriteLine("\nArray ordenado con Merge Sort:");
            MostrarArray(numeros);
            Console.WriteLine("\nPresione una tecla para continuar.....");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("---Busqueda Binaria---");
            Console.WriteLine("Ingrese un número a buscar: ");
            int num = int.Parse(Console.ReadLine());

            BusquedaBinaria(numeros, num);

        }

        static void MergeSort(int[] array, int izquierda, int derecha)
        {
            if (izquierda >= derecha)
                return;

            int medio = (izquierda + derecha) / 2;

            // Dividimos el array en mitades
            MergeSort(array, izquierda, medio);
            MergeSort(array, medio + 1, derecha);

            // Mezclamos las mitades
            Mezclar(array, izquierda, medio, derecha);
        }

        static void Mezclar(int[] array, int izquierda, int medio, int derecha)
        {
            int[] auxiliar = new int[derecha - izquierda + 1];

            //Indice para recorrer la mitad izquierda
            int i = izquierda;
            //Indice para recorrer la mitad derecha (que va desde medio + 1 hasta derecha)
            int j = medio + 1;
            //Indice para recorrer el array auxiliar
            int k = 0;

            // Mezclamos comparando elementos de ambas mitades
            while (i <= medio && j <= derecha)
            {
                if (array[i] <= array[j])
                {
                    auxiliar[k] = array[i];
                    k++;
                    i++;
                }
                else
                {
                    auxiliar[k] = array[j];
                    k++;
                    j++;
                }
            }

            // Copiamos los elementos restantes de la mitad izquierda
            while (i <= medio)
            {
                auxiliar[k] = array[i];
                k++;
                i++;
            }
            // Copiamos los elementos restantes de la mitad derecha
            while (j <= derecha)
            {
                auxiliar[k] = array[j];
                k++;
                j++;
            }
            // Copiamos el array auxiliar de vuelta al original
            for (i = izquierda, k = 0; i <= derecha; i++, k++)
                array[i] = auxiliar[k];
        }

        static void MostrarArray(int[] array)
        {
            foreach (int num in array)
                Console.Write(num + " ");
            Console.WriteLine();
        }

        static void BusquedaBinaria(int[] array, int num)
        {
            int izquierda = 0;
            int derecha = array.Length - 1;
            int medio;

            while (izquierda <= derecha)
            {
                //Se define el punto medio
                medio = (izquierda + derecha) / 2;

                //Si el número se encuentra en el punto medio se imprime la posición
                if (array[medio] == num)
                {
                    Console.WriteLine("El número {0} se encuentra en el indice {1}", num, medio);
                    return;
                }
                //Si el número es menor que el punto medio se busca en la mitad izquierda
                else if (array[medio] < num)
                    izquierda = medio + 1;
                //Si el número es mayor que el punto medio se busca en la mitad derecha
                else
                    derecha = medio - 1;
            }
            //Si el número no se encuentra en el array se imprime un mensaje
            Console.WriteLine("El número {0} no se encuentra en el array", num);
        }
    }
}
