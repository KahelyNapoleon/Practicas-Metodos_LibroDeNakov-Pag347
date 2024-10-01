namespace MetodosPracticasNakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 5, 4, 5, 3, 2, 1, 5 };
            //ElMayorNumero();
            //LastNumber(5);
            //FindTimesNumberAppearInArray(array,5);
            //Console.WriteLine(FindMajorNumberOfNeighborsPositionInIndex(array,4).ToString());
            //Console.WriteLine(FindFirstIndexElementThatBeMajorThanNeighbors(array));
            //Console.WriteLine(reverseNumber(55.23m));


            Console.ReadLine();
        }

        //Ejercicio 2 Libro de Nakov: Capitulo 9 Methods 
        public static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }

        }
        public static void ElMayorNumero()
        {
            Console.WriteLine("Ingrese el valor de 3 numeros:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = GetMax(num1, num2);
            Console.WriteLine("El mayor numero es:{0}", GetMax(result, num3));
        }

        public static void LastNumber(int number)
        {
            string numConvertString = number.ToString();
            int numberLenght = numConvertString.Length;
            char lastNumber = numConvertString[numberLenght - 1];

            switch (lastNumber)
            {
                case '0':
                    Console.WriteLine("Cero");
                    break;
                case '1':
                    Console.WriteLine("One");
                    break;
                case '2':
                    Console.WriteLine("Two");
                    break;
                case '3':
                    Console.WriteLine("Three");
                    break;
                case '4':
                    Console.WriteLine("Four");
                    break;
                case '5':
                    Console.WriteLine("Five");
                    break;
                case '6':
                    Console.WriteLine("Six");
                    break;
                case '7':
                    Console.WriteLine("Seven");
                    break;
                case '8':
                    Console.WriteLine("Eight");
                    break;
                case '9':
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Nothing");
                    break;
            }
        }

        public static void FindTimesNumberAppearInArray(int[] array, int number)
        {
            //Variables
            int count = 0;
            int arrayLength = array.Length;
            int i;

            //Body
            for (i = 0; i < arrayLength; i++)
            {
                if (array[i] == number)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine("El numero {0} aparece {1} veces en el array", number, count);
            }
            else
            {
                Console.WriteLine("No se hallo numero");
            }


        }

        public static bool FindMajorNumberOfNeighborsPositionInIndex(int[] array, int indexEvaluation)
        {
            //5) Escribe un método que verifique si un elemento, desde una cierta posición en un arreglo,
            //es mayor que sus dos vecinos. Prueba si el método funciona correctamente.

            //  5    2    4
            // i-1 < i < i+1  ?? Es Mayor? False : True

            bool esMayor = false;
            int i = indexEvaluation;

            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                esMayor = true;

            }

            return esMayor;


        }

        public static int FindFirstIndexElementThatBeMajorThanNeighbors(int[] array)
        {
            //Variables
            bool itExist = false;
            int indexNumber = 1;
            int i = indexNumber;
            //Cuerpo del Programa
            for (i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    itExist = true;
                    indexNumber = i;
                    break;
                }
                else
                {
                    indexNumber = -1;
                }
            }


            return indexNumber;

        }

        public static decimal reverseNumber(decimal number)
        {
            //Variable
            decimal reverseNumber;
            //Convierto el decimal en tipo string
            string numberToString = number.ToString();
            //Lo convierto en un array de caracteres
            char[] numberInvertir = numberToString.ToCharArray();
            //Invierto los valores de ese array de caracteres
            Array.Reverse(numberInvertir);

            //Vuelvo a repetir proceso a string para llevarlo a su tipo original
            string cadenaInvertida = new string(numberInvertir);
            //finalmente convierto el valor a decimal
            reverseNumber = decimal.Parse(cadenaInvertida);


            return reverseNumber;
        }

    }
}


