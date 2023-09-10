namespace ExcerciseArchitec
{

    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ingresa tu nombre por favor: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"¡Hola, {nombre}! Por favor, elige un ejercicio del siguiente menú:");
            Menu.MostrarMenu();
            while (true)
            {
                string entrada = Console.ReadLine().ToLower();
                if (entrada == "q" || entrada == "exit")
                {
                    break;
                }
                if (int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= 15)
                {
                    switch (eleccion)
                    {
                        case 1:
                            var Excercise1 = new Excercise1();
                            Excercise1.Exe();
                            break;
                        case 2:
                            var Excercise2 = new Excercise2();
                            Excercise2.Exe();
                            break;
                        case 3:
                            var Excercise3 = new Excercise3();
                            Excercise3.Exe();
                            break;
                        default:
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                            Menu.MostrarMenu();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número entre 1 y 15");
                    Menu.MostrarMenu();
                }
            }
            Console.WriteLine("¡Hasta pronto!");
        }
    }
}