namespace ExcerciseArchitec
{

    //Positive Power: Solicita al usuario un número y eleva este número al cuadrado
    //solo si es positivo. 
    public class Excercise1
    {
        public void Exe()
        {
            Console.Write("Por favor, ingresa un número: ");
            string texInput = Console.ReadLine();

            // Intenta convertir la entrada del usuario en un número decimal
            if (double.TryParse(texInput, out double numero))
            {
                // Verifica si el número es positivo
                if (numero > 0)
                {
                    // Eleva el número al cuadrado
                    double resultado = numero * numero;

                    Console.WriteLine($"El cuadrado de {numero} es {resultado}");
                }
                else
                {
                    Console.WriteLine("El número ingresado no es positivo o es cero.");
                }
            }
            else
            {
                Console.WriteLine("La entrada no es un número válido.");
            }
        }
    }

    // Double or Triple: Solicita al usuario dos números. Si el primero es mayor, devuelva 
    // su doble, de lo contrario devuelva el triple del segundo. 

    public class Excercise2
    {
        public void Exe()
        {
            Console.Write("Por favor, ingresa el primer número: ");
            string texInput1 = Console.ReadLine();

            Console.Write("Ahora ingresa el segundo número: ");
            string texInput2 = Console.ReadLine();

            // Intenta convertir las entradas del usuario en números enteros
            if (int.TryParse(texInput1, out int numero1) && int.TryParse(texInput2, out int numero2))
            {
                if (numero1 > numero2)
                {
                    // El primer número es mayor, devuelve su doble
                    int resultado = numero1 * 2;
                    Console.WriteLine($"El doble del primer número ({numero1}) es {resultado}");
                }
                else
                {
                    // El segundo número es mayor o igual, devuelve el triple del segundo
                    int resultado = numero2 * 3;
                    Console.WriteLine($"El triple del segundo número ({numero2}) es {resultado}");
                }
            }
            else
            {
                Console.WriteLine("Ingresaste un dato o número válido.");
            }
        }
    }

    // Root or Square: Pide al usuario un número. Si es positivo, devuelve su raíz 
    // cuadrada, de lo contrario, devuelve su cuadrado.
    public class Excercise3
    {
        public void Exe()
        {
            Console.Write("Por favor, ingresa un número: ");
            string texInput = Console.ReadLine();

            // Intenta convertir la entrada del usuario en un número decimal
            if (decimal.TryParse(texInput, out decimal numero))
            {
                if (numero >= 0)
                {
                    // El número es positivo o cero, devuelve su raíz cuadrada
                    double resultado = Math.Sqrt((double)numero);
                    Console.WriteLine($"La raíz cuadrada de {numero} es {resultado}");
                }
                else
                {
                    // El número es negativo, devuelve su cuadrado
                    decimal resultado = numero * numero;
                    Console.WriteLine($"El cuadrado de {numero} es {resultado}");
                }
            }
            else
            {
                Console.WriteLine("La entrada no es un número válido.");
            }
        }
    }

    // Circle Perimeter:Pide al usuario el radio de un círculo y calcula su perímetro 
    public class Excercise4
    {
        public void Exe()
        {
            // Valor de pi
            double pi = 3.14159265359;

            Console.Write("Por favor, ingresa el radio del círculo: ");
            string texInput = Console.ReadLine();

            // Intenta convertir la entrada del usuario en un número decimal
            if (double.TryParse(texInput, out double radio))
            {
                if (radio >= 0)
                {
                    // Calcula el perímetro del círculo
                    double perimetro = 2 * pi * radio;
                    Console.WriteLine($"El perímetro del círculo con radio {radio} es {perimetro}");
                }
                else
                {
                    Console.WriteLine("El radio debe ser un número positivo o cero.");
                }
            }
            else
            {
                Console.WriteLine("La entrada no es un número válido.");
            }
        }
    }
    // Midweek Day: Solicita al usuario un número entre 1 y 7 y muestra el día de la 
    // semana correspondiente, pero solo considerando los días laborables
    public class Excercise5
    {
        public void Exe()
        {
            Console.Write("Por favor, ingresa un número entre 1 y 7: ");
            string texInput = Console.ReadLine();

            // Intenta convertir la entrada del usuario en un número entero
            if (int.TryParse(texInput, out int numero))
            {
                if (numero >= 1 && numero <= 7)
                {
                    string diaSemana;

                    // Utiliza un switch para determinar el día de la semana correspondiente
                    switch (numero)
                    {
                        case 1:
                            diaSemana = "Lunes";
                            break;
                        case 2:
                            diaSemana = "Martes";
                            break;
                        case 3:
                            diaSemana = "Miércoles";
                            break;
                        case 4:
                            diaSemana = "Jueves";
                            break;
                        case 5:
                            diaSemana = "Viernes";
                            break;
                        default:
                            diaSemana = "No es un día laborable";
                            break;
                    }

                    Console.WriteLine($"El número {numero} corresponde a {diaSemana}");
                }
                else
                {
                    Console.WriteLine("El número debe estar entre 1 y 7.");
                }
            }
            else
            {
                Console.WriteLine("La entrada no es un número válido.");
            }
        }
    }


    // Tax Calculator: Solicita al usuario su salario anual y, si este excede los 12000, 
    // muestra el impuesto a pagar que es el 15% del excedente
    public class Excercise6
    {
        public void Exe()
        {
            // Definimos la cantidad base para no pagar impuesto
            decimal salarioBase = 12000;

            Console.Write("Por favor, ingresa tu salario anual: ");
            string texInput = Console.ReadLine();

            // Intenta convertir la entrada del usuario en un número decimal
            if (decimal.TryParse(texInput, out decimal salarioAnual))
            {
                if (salarioAnual > salarioBase)
                {
                    // Calcula el excedente sobre el salario base
                    decimal excedente = salarioAnual - salarioBase;

                    // Calcula el impuesto como el 15% del excedente
                    decimal impuesto = excedente * 0.15m;

                    Console.WriteLine($"Tu salario anual excede los ${salarioBase:N2}.");
                    Console.WriteLine($"El impuesto a pagar es ${impuesto:N2}");
                }
                else
                {
                    Console.WriteLine("Tu salario anual no excede los $12,000. No debes pagar impuesto.");
                }
            }
            else
            {
                Console.WriteLine("La entrada no es un salario válido.");
            }
        }
    }

    // Remainder Finder: Solicita dos números y muestra el residuo de la división del 
    // primero entre el segundo. 
    public class Excercise7
    {
        public void Exe()
        {
            Console.Write("Por favor, ingresa el primer número: ");
            string texInput1 = Console.ReadLine();

            Console.Write("Ahora, ingresa el segundo número: ");
            string texInput2 = Console.ReadLine();

            // Intenta convertir las entradas del usuario en números enteros
            if (int.TryParse(texInput1, out int numero1) && int.TryParse(texInput2, out int numero2))
            {
                if (numero2 != 0)
                {
                    // Calcula el residuo de la división
                    int residuo = numero1 % numero2;
                    Console.WriteLine($"El residuo de la división de {numero1} entre {numero2} es {residuo}");
                }
                else
                {
                    Console.WriteLine("No puedes dividir entre cero. Por favor, ingresa un segundo número diferente de cero.");
                }
            }
            else
            {
                Console.WriteLine("Al menos una de las entradas no es un número válido.");
            }

        }
    }

    //Sum of Evens: Calcula y muestra la suma de los números pares entre 1 y 50.
    public class Excercise8
    {
        public void Exe()
        {
            int suma = 0;

            for (int numero = 2; numero <= 50; numero += 2)
            {
                suma += numero;
            }

            Console.WriteLine($"La suma de los números pares entre 1 y 50 es: {suma}");
        }
    }

    // Fraction Difference: Solicita al usuario los valores para dos fracciones y muestra la 
    // diferencia entre esas fracciones
    public class Excercise9
    {
        public void Exe()
        {
            Console.Write("Ingresa el numerador de la primera fracción: ");
            string numerador1Input = Console.ReadLine();

            Console.Write("Ingresa el denominador de la primera fracción: ");
            string denominador1Input = Console.ReadLine();

            Console.Write("Ingresa el numerador de la segunda fracción: ");
            string numerador2Input = Console.ReadLine();

            Console.Write("Ingresa el denominador de la segunda fracción: ");
            string denominador2Input = Console.ReadLine();

            // Intenta convertir las entradas del usuario en números enteros
            if (int.TryParse(numerador1Input, out int numerador1) &&
                int.TryParse(denominador1Input, out int denominador1) &&
                int.TryParse(numerador2Input, out int numerador2) &&
                int.TryParse(denominador2Input, out int denominador2))
            {
                // Verifica si los denominadores son diferentes de cero
                if (denominador1 != 0 && denominador2 != 0)
                {
                    // Realiza la resta de fracciones
                    int nuevoDenominador = denominador1 * denominador2;
                    int nuevoNumerador1 = numerador1 * denominador2;
                    int nuevoNumerador2 = numerador2 * denominador1;
                    int resultadoNumerador = nuevoNumerador1 - nuevoNumerador2;

                    Console.WriteLine($"La diferencia de las fracciones es: {resultadoNumerador}/{nuevoDenominador}");
                }
                else
                {
                    Console.WriteLine("Los denominadores no pueden ser cero.");
                }
            }
            else
            {
                Console.WriteLine("Al menos una de las entradas no es un número válido.");
            }

        }
    }


    //  String Length: Pide una palabra al usuario y muestra la longitud de esa palabra
    public class Excercise10
    {
        public void Exe()
        {
            Console.Write("Por favor, ingresa una palabra: ");
            string palabra = Console.ReadLine();

            int longitud = palabra.Length;

            Console.WriteLine($"La longitud de la palabra '{palabra}' es: {longitud}");
        }
    }


    // Average of Four: Pide al usuario cuatro números y muestra el promedio.
    public class Excercise11
    {
        public void Exe()
        {
            Console.Write("Por favor, ingresa el primer número: ");
            string numero1Input = Console.ReadLine();

            Console.Write("Ingresa el segundo número: ");
            string numero2Input = Console.ReadLine();

            Console.Write("Ingresa el tercer número: ");
            string numero3Input = Console.ReadLine();

            Console.Write("Ingresa el cuarto número: ");
            string numero4Input = Console.ReadLine();

            // Intenta convertir las entradas del usuario en números enteros
            if (int.TryParse(numero1Input, out int numero1) &&
                int.TryParse(numero2Input, out int numero2) &&
                int.TryParse(numero3Input, out int numero3) &&
                int.TryParse(numero4Input, out int numero4))
            {
                // Calcula el promedio
                double promedio = (numero1 + numero2 + numero3 + numero4) / 4.0;

                Console.WriteLine($"El promedio de los números ingresados es: {promedio}");
            }
            else
            {
                Console.WriteLine("Al menos una de las entradas no es un número válido.");
            }
        }

    }


    //  Smallest of Fiven: Pide al usuario cinco números y muestra el más pequeño.
    public class Excercise12
    {
        public void Exe()
        {
            int cantidadNumeros = 5;
            int numeroMinimo = int.MaxValue; // Inicializamos con un valor muy grande

            for (int i = 1; i <= cantidadNumeros; i++)
            {
                Console.Write($"Ingresa el número {i}: ");
                string numeroInput = Console.ReadLine();

                if (int.TryParse(numeroInput, out int numero))
                {
                    // Comparamos con el número mínimo actual y actualizamos si es menor
                    if (numero < numeroMinimo)
                    {
                        numeroMinimo = numero;
                    }
                }
                else
                {
                    Console.WriteLine("Al menos una de las entradas no es un número válido.");
                    return; // Salimos del programa si una entrada no es válida
                }
            }

            Console.WriteLine($"El número más pequeño de los cinco ingresados es: {numeroMinimo}");
        }
    }


    //     Vowel Counter: Pide una palabra al usuario y devuelve el número de vocales en 
    // esa palabra. 
    // public class Excercise13{
    //     public void Exe(){

    //     }
    // }

    //Factorial Finder: Pide un número al usuario y devuelve el factorial de ese número.
    public class Excercise14
    {
        public void Exe()
        {
            Console.Write("Por favor, ingresa un número entero positivo: ");
            string texInput = Console.ReadLine();

            if (int.TryParse(texInput, out int numero) && numero >= 0)
            {
                long factorial = CalcularFactorial(numero);

                Console.WriteLine($"El factorial de {numero} es: {factorial}");
            }
            else
            {
                Console.WriteLine("Debes ingresar un número entero positivo válido.");
            }
        }
        static long CalcularFactorial(int numero)
        {
            if (numero == 0)
            {
                return 1; // El factorial de 0 es 1 por definición
            }
            long factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            return factorial;

        }
    }

    // InRange Validator : Pide un número al usuario y verifica si está en el rango de 10 a 20 
    // (ambos incluidos).
    public class Excercise15
    {
        public void Exe()
        {
            Console.Write("Por favor, ingresa un número: ");
            string texInput = Console.ReadLine();

            if (int.TryParse(texInput, out int numero))
            {
                if (numero >= 10 && numero <= 20)
                {
                    Console.WriteLine($"El número {numero} está en el rango de 10 a 20 (inclusive).");
                }
                else
                {
                    Console.WriteLine($"El número {numero} NO está en el rango de 10 a 20.");
                }
            }
            else
            {
                Console.WriteLine("La entrada no es un número válido.");
            }
        }
    }
}