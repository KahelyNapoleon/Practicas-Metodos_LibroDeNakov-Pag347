using System.ComponentModel;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;

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

            //int[] arr = SumOfTwoVeryLongNumbers(13101, 24422);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}

            //Console.WriteLine(Factorial(99));

            //Console.WriteLine(Average(array));

            //Console.WriteLine(SolveLinealEquation(5,2));

            MultiTaskMethod();

            //Console.ReadLine();
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

        //- Put the digits from an integer number into a reversed order
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

        public static int[] SumOfTwoVeryLongNumbers(long number1, long number2)
        {
            //Write a method that calculates the sum of two very long positive integer numbers.
            //The numbers are represented as array digits and the last digit(the ones) is stored 
            //in the array at index 0.Make the method work for all numbers with length up to 10,000 digits.

            //Variables
            //1) Convertir los numeros a un array de enteros
            int[] num1 = number1.ToString().Select(digito => int.Parse(digito.ToString())).ToArray();
            int[] num2 = number2.ToString().Select(digito => int.Parse(digito.ToString())).ToArray();
            //2)Asignar array de resultado 
            int[] result = new int[num2.Length + num1.Length];

            int decena = 0;
            int[] decenaArray = new int[2];
            //Procedimiento:
            //1) Sumar los indices de cada array e ir sumando la unidad del resultado en caso
            // que result > 9

            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] + num2[i] > 9)
                {
                    //El resultado debe almacenarse por digito en un array
                    decena = num1[i] + num2[i];
                    decenaArray = ConvertirEnArray(decena);

                    //El resultado debe ingresarse en el array de resultado
                    //La decena en el indice = i del array de resultado
                    //y la unidad en la siguiente evaluescion de suma de arrays de resultados
                    if (i + 1 == num1.Length)
                    {
                        result[i] = decenaArray[1];
                        result[i + 1] = decenaArray[0];
                    }
                    else
                    {
                        num1[i + 1] = num1[i + 1] + decenaArray[0];
                    }

                    //La unidad del resultado se almacena en el indice i del array de resultado
                    result[i] = decenaArray[1];

                }
                else
                {
                    //Si el resultaod de la suma de ambos digitos no supera a 9
                    // se alamcena la unidad en el array de resultado
                    result[i] = num1[i] + num2[i];
                }

            }

            return result;



        }

        public static BigInteger Factorial(int number)
        {
            BigInteger result = 0;
            result = number;

            while (number > 1)
            {
                number--;
                result *= number;
            }
            return result;
        }

        //- Calculate the average of given sequence of numbers.
        public static decimal Average(int[] Secuence)
        {
            decimal Number = 0;

            for (int i = 0; i < Secuence.Length; i++)
            {
                Number += Secuence[i];
            }

            decimal Promedio = Number / Secuence.Length;

            decimal redondeo = decimal.Round(Promedio, 2);

            return redondeo;
        }

        //- Solve the linear equation a* x + b = 0.
        public static int SolveLinealEquation(int a, int b)
        {
            // a2x + b = 0
            int aSquad = a * a;
            int aAfterEqual = 0;
            int bAfterEqual = 0;
            int result = 0;
            if (b >= 0)
            {
                bAfterEqual = b;
            }
            else
            {
                bAfterEqual = -b;
            }
            if (aSquad >= 0)
            {
                aAfterEqual = aSquad;
            }
            else
            {
                aAfterEqual = -aSquad;
            }


            result = aAfterEqual + bAfterEqual;


            return result;
        }


        //  Write a program that solves the following tasks:
        //- Put the digits from an integer number into a reversed order.
        //- Calculate the average of given sequence of numbers.
        //- Solve the linear equation a* x + b = 0.
        //Create appropriate methods for each of the above tasks.
        //Make the program show a text menu to the user. By choosing an option of that menu, the user will be able to choose which task to be invoked.
        public static void MultiTaskMethod()
        {
            //Preugntar que opcion elejir
            int eleccion = 0;
            do
            {
                Menu();
                eleccion = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (eleccion)
                {
                    case 1:
                        Caso1();
                        break;
                    case 2:
                        Caso2();
                        break;
                    case 3:
                        Caso3();
                       
                        break;
                    case 4:
                    default:
                        break;
                }

                HashSet<int> opcionesValidas = new HashSet<int> {1,2,3,4};

                if (!opcionesValidas.Contains(eleccion))
                {
                    Console.WriteLine("Numero de Opcion Incorrecto \n Vuelve a intentarlo \n");
                }
                



            } while (eleccion != 4);
            



        }

       






        //Metodos Auxiliares
        public static int[] ConvertirEnArray(long number)
        {
            int[] array = number.ToString().Select(digito => int.Parse(digito.ToString())).ToArray();

            return array;
        }


        //Barra deMenu para Metodo MultiTask
        public static void Menu()
        {
            //Variables
            string[] Opciones =
          {
                "1-Put the digits from an integer number into a reversed order.",
                "2-Average Of Given Secuence Of Numbers.",
                "3-Solve the linear equation a* x + b = 0.",
                "4-Salir"

            };
            //Procedure
            Console.WriteLine("Elija una opcion:");

            for (int i =0; i< Opciones.Length; i++)
            {
                Console.WriteLine(Opciones[i]);
            }

            //Console.WriteLine(Opciones[0]);
            //Console.WriteLine(Opciones[1]);
            //Console.WriteLine(Opciones[2]);
            //Console.WriteLine(Opciones[3]);

        }

        //Metodo para crear un array de enteros
        public static int[] CrearArrayDeEnteros(int largoArray)
        {
            //Variables
            int[] array = new int[largoArray];

            if(largoArray > 1)
            {
                Console.WriteLine($"Ingrese los {largoArray} valores:");
                for (int i = 0; i < largoArray; i++)
                {
                    Console.Write($"Ingrese array[{i}]:");
                    array[i] = int.Parse(Console.ReadLine());
                    //Console.WriteLine();
                }
            }
            else
            {
                //Retorna Array con todos sus valores igual a cero
                return array;
            }
            return array;
        }


        //METODOS PARA LOS PROCEDIMIENTOS DE CADA OPCION EN MULTITASKMETHOD

        //Caso1
        public static void Caso1()
        {
            Console.WriteLine("Ingrese un numero para invertirlo");
            int numeroInvertir = int.Parse(Console.ReadLine());
            Console.WriteLine(reverseNumber(numeroInvertir));
        }

        //Caso2
        public static void Caso2()
        {
            Console.WriteLine("Ingrese Cantidad de numeros a promediar");
            int largo = int.Parse(Console.ReadLine());
            int[] arrayPromedio = CrearArrayDeEnteros(largo);
            Console.Write("El promedio de los {0} numeros es de:", largo);
            Console.Write(Average(arrayPromedio));
            Console.WriteLine();
        }

        //Caso3
        public static void Caso3()
        {
            Console.WriteLine("Ingrese los valores de a y b de la ecuacion lineal: a* x + b = 0.");
            Console.Write("A = "); int a = int.Parse(Console.ReadLine());
            Console.Write("B = "); int b = int.Parse(Console.ReadLine());
            int result = SolveLinealEquation(a,b);
            Console.WriteLine("El resultado es de:{0}",result);
        }


    }
}


