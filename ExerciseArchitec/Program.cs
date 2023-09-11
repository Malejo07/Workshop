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
                        case 4:
                            var Excercise4 = new Excercise4();
                            Excercise4.Exe();
                            break;
                        case 5:
                            var Excercise5 = new Excercise5();
                            Excercise5.Exe();
                            break;
                        case 6:
                            var Excercise6 = new Excercise6();
                            Excercise6.Exe();
                            break;
                        case 7:
                            var Excercise7 = new Excercise7();
                            Excercise7.Exe();
                            break;
                        case 8:
                            var Excercise8 = new Excercise8();
                            Excercise8.Exe();
                            break;
                        case 9:
                            var Excercise9 = new Excercise9();
                            Excercise9.Exe();
                            break;
                        case 10:
                            var Excercise10 = new Excercise10();
                            Excercise10.Exe();
                            break;
                        case 11:
                            var Excercise11 = new Excercise11();
                            Excercise11.Exe();
                            break;
                        case 12:
                            var Excercise12 = new Excercise12();
                            Excercise12.Exe();
                            break;
                        // case 13:
                        //     var Excercise13 = new Excercise13();
                        //     Excercise13.Exe();
                        //     break;
                        case 14:
                            var Excercise14 = new Excercise14();
                            Excercise14.Exe();
                            break;
                        case 15:
                            var Excercise15 = new Excercise15();
                            Excercise15.Exe();
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