//using static Practica_Parcial_2.Program;

//namespace Practica_Parcial_2
//{

//    //delegate int Operacion(int x);
//    internal class Program
//    {

//        //static int variableGlobal = 0;

//        //static void ModificarVariableGlobal(int nuevoValor)
//        //{
//        //    variableGlobal = nuevoValor;
//        //}

//        // static int Cuadrado(int numero)
//        //{
//        //    return numero * numero;
//        //}

//        //static void Informacion(string nombre, int edad)
//        //{
//        //    Console.WriteLine($"{nombre} tiene {edad} años");
//        //}

//        //static int Sumatoria(int numero)
//        // {
//        //     // Verificar que el número sea positivo
//        //     if (numero <= 0)
//        //     {
//        //         return -1; // O podrías lanzar una excepción si prefieres
//        //     }

//        //     int suma = 0;
//        //     for (int i = 1; i <= numero; i++)
//        //     {
//        //         suma += i;
//        //     }

//        //     return suma;
//        // }

//        //static int Resta (int x, int y)
//        //{
//        //    return x - y;
//        //}

//        //static string Unir (string x, string y)
//        //{
//        //    return x + y;
//        //}

//        //static int Factorial(int numero)
//        //{

//        //   if(numero == 0)
//        //    {
//        //        return 1;
//        //    }
//        //    int resultado = 1;
//        //    while (numero > 0)
//        //    {
//        //        resultado *= numero;
//        //        numero--;
//        //    }

//        //    return resultado;
//        //}

//        //static void Opciones()
//        //{
//        //    bool continuar = true;
//        //    while (continuar)
//        //    {
//        //        Console.WriteLine("\nBienvenido al Restaurante. Sus opciones son:");
//        //        Console.WriteLine("1- Cargar un nuevo menú.");
//        //        Console.WriteLine("2- Finalizar la cuenta.");
//        //        Console.WriteLine("3- Salir.");

//        //        Console.Write("Seleccione una opción: ");
//        //        int opcion = int.Parse(Console.ReadLine());

//        //        switch (opcion)
//        //        {
//        //            case 1:
//        //                Console.WriteLine("Cargando un nuevo menú...");
//        //                break;
//        //            case 2:
//        //                Console.WriteLine("Finalizando la cuenta...");
//        //                break;
//        //            case 3:
//        //                Console.WriteLine("Saliendo...");
//        //                continuar = false;
//        //                break;
//        //            default:
//        //                Console.WriteLine("Opción no válida, intente de nuevo.");
//        //                break;
//        //        }
//        //    }
//        //}

//        //static int RemerasConfeccionadas(int remeras)
//        //{
//        //    int totalHilo = 0;

//        //    for(int i = 0; i < remeras; i++)
//        //    {
//        //        Console.Write($"Ingrese los metros de hilo utilizados para la remera {i + 1}: ");
//        //        int hiloRemera = int.Parse(Console.ReadLine());
//        //        totalHilo += hiloRemera;
//        //    }

//        //    return totalHilo;
//        //}

//        //static void CalcularTotalViaje()
//        //{
//        //    Console.Write("Ingrese el importe del viaje: ");
//        //    double importeViaje = double.Parse(Console.ReadLine());

//        //    Console.Write("Ingrese la cantidad de personas: ");
//        //    int cantidadPersonas = int.Parse(Console.ReadLine());

//        //    Console.Write("Ingrese el importe de una excursión: ");
//        //    double importeExcursion = double.Parse(Console.ReadLine());

//        //    double total = cantidadPersonas * (importeViaje +  importeExcursion);
//        //    Console.WriteLine($"El total del viaje es: ${total}");
//        //}

//        //static void ReservarPasajes()
//        //{
//        //    Console.Write("Ingrese la cantidad de pasajes a reservar: ");
//        //    int cantidadPasajes = int.Parse(Console.ReadLine());

//        //    for (int i = 1; i <= cantidadPasajes; i++)
//        //    {
//        //        Console.WriteLine($"Pasaje {i} reservado");
//        //    }
//        //}

//        //static void Sumar(int numero1, int numero2)
//        //{
//        //    int resultado = numero1 + numero2;
//        //    Console.WriteLine($"El resultado de sumar {numero1} y {numero2} es: {resultado}");
//        //}

//        //static void Restar(int numero1, int numero2)
//        //{
//        //    int resultado = numero1 - numero2;
//        //    Console.WriteLine($"El resultado de restar {numero1} de {numero2} es: {resultado}");
//        //}

//        //static void Multiplicar(int numero1, int numero2)
//        //{
//        //    int resultado = numero1 * numero2;
//        //    Console.WriteLine($"El resultado de multiplicar {numero1} y {numero2} es: {resultado}");
//        //}

//        //static void Dividir(int numero1, int numero2)
//        //{
//        //    if (numero2 == 0)
//        //    {
//        //        Console.WriteLine("No se puede dividir por cero.");
//        //    }
//        //    else
//        //    {
//        //        double resultado = (double)numero1 / numero2;
//        //        Console.WriteLine($"El resultado de dividir {numero1} entre {numero2} es: {resultado}");
//        //    }
//        //}

//        //record Persona
//        //{
//        //    public string Nombre { get; set; }
//        //    public string Apellido { get; set; }
//        //    public int Edad { get; set; }

//        //    public string GrupoSanguineo { get; set; }

//        //}

//        //record Auto
//        //{
//        //    public string Marca { get; set; }
//        //    public string Modelo { get; set; }
//        //    public int CantidadPuertas { get; set; }
//        //    public int KmsRecorridos { get; set; }

//        //    public Auto(string marca, string modelo, int cantidadPuertas, int kmsRecorridos)
//        //    {
//        //        Marca = marca;
//        //        Modelo = modelo;
//        //        CantidadPuertas = cantidadPuertas;
//        //        KmsRecorridos = kmsRecorridos;
//        //    }

//        //}

//        //public enum TipoAnimal
//        //{
//        //    Aereo,
//        //    Terrestre,
//        //    Acuatico
//        //}

//        //record Animal
//        //{
//        //    public TipoAnimal Tipo { get; set; }
//        //    public int CantidadPatas { get; set; }

//        //    public Animal(TipoAnimal tipo, int cantidadPatas)
//        //    {
//        //        Tipo = tipo;
//        //        CantidadPatas = cantidadPatas;
//        //    }

//        //}

//        //public record Alumno
//        //{
//        //    public int Legajo { get; set; }
//        //    public int Calificacion { get; set; }

//        //    public Alumno(int legajo, int calificacion)
//        //    {
//        //        Legajo = legajo;
//        //        Calificacion = calificacion;
//        //    }
//        //}

//        //public record Producto
//        //{
//        //    public int Codigo { get; set; }
//        //    public int Precio { get; set; }


//        //}

//        //static int Cuadrado(int lado)
//        // {
//        //     return 4 * lado;
//        // }

//        //static int Sumatoria(int max)
//        // {
//        //     int suma = 0;
//        //     for (int i = 1; i <= max; i++)
//        //     {
//        //         suma += i;
//        //     }
//        //     return suma;
//        // }

//        //static void Repetir(int cantidad, string letra)
//        //{
//        //    for (int i = 0; i < cantidad; i++)
//        //    {
//        //        Console.Write(letra);
//        //    }
//        //    Console.WriteLine();
//        //}

//        //record Persona
//        //{
//        //    public string Nombre { get; set; }
//        //    public int Edad { get; set; }

//        //    public Persona(string nombre, int edad)
//        //    {
//        //        Nombre = nombre;
//        //        Edad = edad;
//        //    }
//        //}

//        //public record Coche(string Modelo, int CantPuertas);

//        //public record Empleado(int legajo, double sueldo);

//        //public record Casa (int habitaciones, string ubicacion);

//        //public record Producto(int Codigo, int Estado);

//        //static void Cuadrado(int lado, ref int perimetro)
//        //{
//        //    if (lado <= 0)
//        //    {
//        //        throw new ArgumentException("El lado del cuadrado no puede ser 0 o negativo.");
//        //    }

//        //    perimetro = 4 * lado;
//        //}

//        //static void Repetir(int cantidad, string letra)
//        //{
//        //    if (cantidad <= 0)
//        //    {
//        //        throw new ArgumentException("La cantidad no puede ser 0 o negativa.");
//        //    }

//        //    for (int i = 0; i < cantidad; i++)
//        //    {
//        //        Console.Write(letra);
//        //    }
//        //    Console.WriteLine();
//        //}

//        //static void Informacion(string nombre, int edad)
//        //{
//        //    if (nombre == "" || edad == null) {
//        //        throw new ArgumentException("Ningun de los dos parametros puede estar vacio");
//        //    }
//        //    if(edad < 0)
//        //    {
//        //        throw new ArgumentException("La edad no puede ser negativa");
//        //    }
//        //}

//        static void VerificarLongitudLegajo(string codigo)
//        {
//            if (codigo.Length < 6 || codigo.Length > 8)
//            {
//                throw new ArgumentException("El código de legajo debe tener entre 6 y 8 caracteres.");
//            }

//            Console.WriteLine("Código de legajo válido.");
//        }

//        //static void Main(string[] args)
//        {

//            //Ejercicio 1

//            bool[,] compartimientos = new bool[3, 3];

//            Random random = new Random();
//            int intentos = 3;

//            Console.WriteLine("Juego del Fantasma - ¡Encuentra el fantasma!");
//            Console.WriteLine("Tienes 3 intentos. ¡Buena suerte!");
//            Console.WriteLine("Recorda que no podes volver a elegir la misma posicion");


//            for (int i = 0; i < intentos; i++)
//            {
//                int fantamaFila = random.Next(0, 3);
//                int fantasmaColumna = random.Next(0, 3);

//                Console.WriteLine("Elegi una fila (entre 0 y 2)");
//                int jugadorFila = int.Parse(Console.ReadLine());


//                if (jugadorFila < 0 || jugadorFila > 2)
//                {
//                    Console.WriteLine("Elegiste mal la fila. Volve a empezar");
//                    return;
//                }

//                Console.WriteLine("Elegi una columna (entre 0 y 2)");
//                int jugadorColumna = int.Parse(Console.ReadLine());

//                if (jugadorColumna < 0 || jugadorColumna > 2)
//                {
//                    Console.WriteLine("Elegiste mal la columna. Volve a empezar");
//                    return;
//                }

//                if (compartimientos[jugadorFila, jugadorColumna])
//                {
//                    Console.WriteLine("Ya elegiste esta posición antes. Has perdido.");
//                    return;
//                }

//                compartimientos[jugadorFila, jugadorColumna] = true;

//                if (jugadorFila == fantamaFila && jugadorColumna == fantasmaColumna)
//                {
//                    Console.WriteLine("¡Encontraste al fantasma! Has perdido.");
//                    return;
//                }
//                else
//                {
//                    Console.WriteLine("Aquí no hay fantasma. Sigue jugando.");
//                }
//            }

//            Console.WriteLine("¡Felicidades! ¡Has ganado!");

//            Console.WriteLine();



//            //Ejercicio 2

//            string rutaArchivo = "dispositivos.txt";
//            string[] lineas = File.ReadAllLines(rutaArchivo);
//            int[] dispositivosPorMinuto = new int[60];
//            int dispositivosTotales = 0;

//            foreach (string linea in lineas)
//            {
//                var partes = linea.Split(';');
//                string hora = partes[1];
//                int minutoAnalizado = int.Parse(hora.Substring(3, 2));
//                int totalConexiones = int.Parse(partes[3]);

//                dispositivosPorMinuto[minutoAnalizado] += totalConexiones;
//                dispositivosTotales += totalConexiones;
//                Console.WriteLine(dispositivosPorMinuto);
//                Console.WriteLine(dispositivosTotales);

//            }
//            for (int i = 0; i < dispositivosPorMinuto.Length; i++)
//            {

//                if (dispositivosPorMinuto[i] > 0)
//                {
//                    string disp = ($"{DateTime.Now} - Minuto: {i} - Total Conexiones: {dispositivosPorMinuto[i]}" + Environment.NewLine);
//                    File.AppendAllText("dispositivosPorMinuto.txt", disp);
//                }
//            }

//            Console.WriteLine($"La cantidad total de dispositivos conectados es de {dispositivosTotales}");

//            Console.WriteLine();


//            //Ejercicio 3

//            Comparison<int[]> compararJugadores = (jugador1, jugador2) =>
//            {
//                int victoriasJugador1 = 0;
//                int victoriasJugador2 = 0;

//                if (jugador1[0] > jugador2[0]) victoriasJugador1++;
//                else if (jugador1[0] < jugador2[0]) victoriasJugador2++;


//                if (jugador1[1] > jugador2[1]) victoriasJugador1++;
//                else if (jugador1[1] < jugador2[1]) victoriasJugador2++;


//                if (victoriasJugador1 == 2) return 1;
//                else if (victoriasJugador2 == 2) return -1;
//                else return 0;
//            };

//            int[] jugadorA = { 6, 2 };
//            int[] jugadorB = { 2, 6 };
//            int[] jugadorC = { 3, 1 };
//            int[] jugadorD = { 4, 3 };


//            Console.WriteLine($"Resultado A vs B: {compararJugadores(jugadorA, jugadorB)}");
//            Console.WriteLine($"Resultado A vs C: {compararJugadores(jugadorA, jugadorC)}");
//            Console.WriteLine($"Resultado C vs D: {compararJugadores(jugadorC, jugadorD)}");

//            Console.WriteLine();


//            //Ejercicio 4


//            while (true)
//            {
//                Console.WriteLine("Ingrese el código de legajo (o 'x' para salir):");
//                string codigo = Console.ReadLine();

//                if (codigo.ToLower() == "x")
//                {
//                    break; 
//                }

//                try
//                {
//                    VerificarLongitudLegajo(codigo);
//                    Console.WriteLine("1"); 
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Error: {ex.Message}");
//                }
//            }
       

//        //**************************************************************


//        //string rutaArchivo = "paises.txt";
//        //string[] lineas = File.ReadAllLines(rutaArchivo);

//        //string paisMasLargo = "";

//        //foreach (string pais in lineas.Skip(1))
//        //{
//        //    var nombres = pais.Split(';');
//        //    if (nombres.Length > 0 && nombres[0].Length > paisMasLargo.Length)
//        //    {
//        //        paisMasLargo = nombres[0];
//        //    }

//        //}
//        //File.WriteAllText("paisMasLargo.txt", paisMasLargo);

//        //foreach (string linea in lineas.Skip(1))
//        //{
//        //    var partes = linea.Split(';');

//        //    if (partes[2].Trim() == "Europa")
//        //    {
//        //        string paisesEuropeos = partes[0] + "," + partes[1] + Environment.NewLine;
//        //        File.AppendAllText("paisesEuropeos.txt", paisesEuropeos);
//        //    }

//        //}

//        //string cadena = "Hola mundo " + Environment.NewLine + "Adiós mundo " + "\r\n";




//        //string ruta = "acciones.txt";

//        //while (true)
//        //{
//        //    try
//        //    {
//        //        Console.WriteLine("Ingrese el primer número (o 'salir' para finalizar):");
//        //        string entrada1 = Console.ReadLine();
//        //        if (entrada1 == "salir") break;

//        //        Console.WriteLine("Ingrese el segundo número:");
//        //        string entrada2 = Console.ReadLine();

//        //        int num1 = int.Parse(entrada1);
//        //        int num2 = int.Parse(entrada2);


//        //        int resultado = num1 / num2;

//        //        string mensaje = $"{DateTime.Now} - OK - {resultado}";
//        //        File.AppendAllText(ruta, mensaje);
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        string mensajeError = $"{DateTime.Now} - ERROR - {ex.Message}";
//        //        File.AppendAllText(ruta, mensajeError);
//        //    }
//        //}

//        //if (File.Exists("tanque.txt") == false)
//        //{
//        //    Console.WriteLine("No existe");
//        //    return;
//        //}

//        //try
//        //{
//        //    double temperaturaMaxima = double.MinValue;
//        //    string[] lineas = File.ReadAllLines("tanque.txt");

//        //    foreach (var linea in lineas)
//        //    {
//        //        Console.WriteLine(linea.Trim());
//        //        string[] partes = linea.Split('|');
//        //        if (partes.Length == 2 && double.TryParse(partes[1], out double temperatura))
//        //        {
//        //            temperaturaMaxima = Math.Max(temperatura, temperaturaMaxima);
//        //        }
//        //    }

//        //        Console.WriteLine($"La temperatura máxima registrada es: {temperaturaMaxima}");

//        //}

//        //catch (Exception ex)
//        //{
//        //    Console.WriteLine($"Se produjo un error al leer el archivo: {ex.Message}");
//        //}




//        //    var persona = ("Alf", -10);
//        //try
//        //{
//        //    Informacion(persona.Item1, persona.Item2);
//        //    Console.WriteLine($"Nombre: {persona.Item1}, edad: {persona.Item2}");
//        //}
//        //catch (Exception e)
//        //{
//        //    Console.WriteLine($"Error: {e.Message}");
//        //}

//        //try
//        //{
//        //    int perimetro = 0;
//        //    Cuadrado(4, ref perimetro);
//        //    Console.WriteLine($"Perímetro del cuadrado: {perimetro}");
//        //}
//        //catch (ArgumentException ex)
//        //{
//        //    Console.WriteLine($"Error en Cuadrado: {ex.Message}");
//        //}

//        //try
//        //{
//        //    Repetir(-5, "A");
//        //}
//        //catch (ArgumentException ex)
//        //{
//        //    Console.WriteLine($"Error en Repetir: {ex.Message}");
//        //}

//        //int[] vector = new int[3] { 1, 2, 3 };

//        //try
//        //{
//        //    Console.WriteLine("Ingrese un índice del vector (recuerde que solo hay posiciones 0, 1 y 2):");
//        //    int indice = int.Parse(Console.ReadLine());

//        //    Console.WriteLine($"El valor en la posición {indice} es {vector[indice]}.");
//        //}
//        //catch (IndexOutOfRangeException)
//        //{
//        //    Console.WriteLine("Error: El índice está fuera de los límites del vector.");
//        //}
//        //catch(Exception ex) { 
//        //     Console.WriteLine($"Error inesperado: {ex.Message}");
//        //    }

//        //try
//        //{
//        //    Console.WriteLine("Ingrese el primer número:");
//        //    int numero1 = int.Parse(Console.ReadLine());

//        //    Console.WriteLine("Ingrese el segundo número:");
//        //    int numero2 = int.Parse(Console.ReadLine());

//        //    int suma = numero1 + numero2;
//        //    Console.WriteLine($"La suma es: {suma}");
//        //}
//        //catch (Exception ex){
//        //    Console.WriteLine($"Error inesperado: {ex.Message}");
//        //}

//        //Producto[] productos = new Producto[10];
//        //Random random = new Random();
//        //for (int i = 0; i < productos.Length; i++)
//        //{
//        //    productos[i] = new Producto(random.Next(1000, 10000), random.Next(1, 5));
//        //}

//        //foreach(var producto in productos)
//        //{
//        //    Console.WriteLine(producto.ToString());
//        //}

//        //Predicate<Producto> productoParaRevisar = p => p.Estado == 2 || p.Estado == 3;


//        ////Producto[] productosActualizados = productos.Select(p =>
//        ////    productoParaRevisar(p) ? new Producto(p.Codigo, -1) : p
//        ////).ToArray();

//        //Producto[] productosActualizados = new Producto[productos.Length];

//        //for (int i = 0; i < productos.Length; i++)
//        //{
//        //    if (productoParaRevisar(productos[i]))
//        //    {
//        //        productosActualizados[i] = new Producto(productos[i].Codigo, -1);
//        //    }
//        //    else
//        //    {
//        //        productosActualizados[i] = productos[i];
//        //    }
//        //}

//        //Console.WriteLine("\nProductos actualizados:");
//        //foreach (var producto in productosActualizados)
//        //{
//        //    Console.WriteLine($"Producto {producto.Codigo}, Estado: {producto.Estado}");
//        //}


//        //        Casa[] casas = new Casa[]
//        //        {
//        //            new Casa(4, "Pilar"),
//        //new Casa(3, "Escobar"),
//        //new Casa(2, "Caballito"),
//        //new Casa(3, "Lomas de Zamora"),
//        //        };

//        //        Casa[] casasConTresHabitaciones = Array.FindAll(casas, c => c.habitaciones == 3);

//        //        foreach (var casa in casasConTresHabitaciones)
//        //        {
//        //            Console.WriteLine($"Casa en {casa.ubicacion} con {casa.habitaciones} habitaciones.");
//        //        }

//        //Random random = new Random();
//        //Empleado[] empleados = new Empleado[5];

//        //for(int i = 0; i < empleados.Length; i++)
//        //{
//        //    empleados[i] = new Empleado(
//        //        random.Next(1000, 2001),
//        //        random.Next(200000, 300001));
//        //}

//        //foreach(var item in empleados)
//        //{
//        //    Console.WriteLine(item);
//        //}

//        //Array.ForEach(empleados, empleado =>
//        //{
//        //    double aumento = empleado.sueldo < 250000 ? 0.15 : 0.10;
//        //    double nuevoSueldo = empleado.sueldo * (1 + aumento);
//        //    Console.WriteLine($"Legajo: {empleado.legajo}, " +
//        //        $"Sueldo actual: {empleado.sueldo}, Nuevo sueldo: {(int)nuevoSueldo}");
//        //});

//        //Console.WriteLine("Ingrese el legajo a buscar:");
//        //int legajoBuscado = int.Parse(Console.ReadLine());
//        //Empleado empleadoEncontrado = Array.Find(empleados, e => e.legajo == 
//        //legajoBuscado);

//        //if (empleadoEncontrado != null)
//        //{
//        //    Console.WriteLine($"Empleado encontrado: Legajo " +
//        //        $"{empleadoEncontrado.legajo}, Sueldo {empleadoEncontrado.sueldo}");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("Legajo no encontrado.");
//        //}

//        //     Coche[] coches = new Coche[]
//        //{
//        //     new Coche("Modelo A", 4),
//        //     new Coche("Modelo B", 5),
//        //     new Coche("Modelo C", 3),
//        //     new Coche("Modelo D", 5),
//        //     new Coche("Modelo E", 2)
//        //};

//        //     Coche[] cochesConCincoPuertas = Array.FindAll(coches, c => c.CantPuertas == 5);

//        //     Console.WriteLine("Coches con 5 puertas:");
//        //     foreach (var coche in cochesConCincoPuertas)
//        //     {
//        //         Console.WriteLine($"Modelo: {coche.Modelo}, Puertas: {coche.CantPuertas}");
//        //     }



//        //var persona1 = new Persona("Alice", 30);
//        //var persona2 = new Persona("Bob", 25);

//        //Comparison<Persona> Mayor = (Persona persona1, Persona persona2) =>
//        //{
//        //    if (persona1.Edad > persona2.Edad) return 1;
//        //    if (persona1.Edad < persona2.Edad) return -1;
//        //    return 0;
//        //};

//        //int res = Mayor(persona1, persona2);

//        //Console.WriteLine(res);

//        //Comparison<int> Mayor = (valor1, valor2) =>
//        //{
//        //    if (valor1 > valor2) return 1;
//        //    if (valor1 < valor2) return -1;
//        //    return 0;
//        //};

//        //int resultado1 = Mayor(5, 3); // Devolverá 1
//        //int resultado2 = Mayor(3, 3); // Devolverá 0
//        //int resultado3 = Mayor(2, 3); // Devolverá -1

//        //Console.WriteLine(resultado1);
//        //Console.WriteLine(resultado2);
//        //Console.WriteLine(resultado3);


//        //Operacion cuadrado = Cuadrado;
//        //int perimetro = cuadrado(4);
//        //Console.WriteLine($"Perímetro del cuadrado: {perimetro}");

//        //Operacion sumatoria = Sumatoria;
//        //int sumaTotal = sumatoria(5);
//        //Console.WriteLine($"Sumatoria: {sumaTotal}");

//        //Action<int, string> repetir = Repetir;
//        //repetir(5, "A");

//        //Action<int, string> repetirAnonimo = (cantidad, letra) =>
//        //{
//        //    for (int i = 0; i < cantidad; i++)
//        //    {
//        //        Console.Write(letra);
//        //    }

//        //};

//        //repetirAnonimo(5, "B");

//        //Func<int, int, int> Potencia = (basePotencia, exponente) => 
//        //(int)Math.Pow(basePotencia, exponente);
//        //Console.WriteLine(Potencia(4, 4));

//        //Action<int> Secuencia = max =>
//        //{
//        //    for (int i = 1; i < max; i++)
//        //    {
//        //        Console.WriteLine(i + " ");
//        //    }
//        //    Console.WriteLine();
//        //};
//        //Secuencia(15);

//        //    Producto[] productos = new Producto[5];  

//        //    Random random = new Random();

//        //    for(int i = 0; i < productos.Length; i++)
//        //    {
//        //        productos[i] = new Producto
//        //        {
//        //            Codigo = random.Next(1000, 2001),
//        //            Precio = random.Next(500, 25001)
//        //        };
//        //    }

//        //int precioMaximo = productos.Max(p => p.Precio);
//        //int precioMinimo = productos.Min(p => p.Precio);

//        //    Producto[] productosConAumento = new Producto[productos.Length];

//        //    for(int i = 0;i < productos.Length;i++)
//        //    {
//        //        productosConAumento[i] = new Producto
//        //        {
//        //            Codigo = productos[i].Codigo,
//        //            Precio = (int)(productos[i].Precio * 1.10)
//        //        };
//        //    }

//        //    Console.WriteLine("Productos originales:");
//        //    foreach (var producto in productos)
//        //    {
//        //        Console.WriteLine($"Código: {producto.Codigo}, Precio: {producto.Precio}");
//        //    }

//        //    Console.WriteLine($"\nPrecio máximo: {precioMaximo}");
//        //    Console.WriteLine($"Precio mínimo: {precioMinimo}");

//        //    Console.WriteLine("\nProductos con aumento del 10%:");
//        //    foreach (var producto in productosConAumento)
//        //    {
//        //        Console.WriteLine($"Código: {producto.Codigo}, Precio: {producto.Precio}");
//        //    }




//        //Alumno[] alumnos = new Alumno[10];

//        //Random random = new Random();

//        //for (int i = 0; i < alumnos.Length; i++)
//        //{
//        //    int legajo = 1000 + i;
//        //    int calificacion = random.Next(1, 11);
//        //    alumnos[i] = new Alumno(legajo, calificacion);
//        //}

//        //int sumaCalificaciones = 0;

//        //foreach (var alumno in alumnos)
//        //{
//        //    sumaCalificaciones += alumno.Calificacion;
//        //}

//        //double promedio = (double)sumaCalificaciones / alumnos.Length;

//        //Console.WriteLine($"El promedio de las calificaciones es: {promedio:F2}");

//        //Animal[] animales = new Animal[3];

//        //for (int i = 0; i < animales.Length; i++)
//        //{
//        //    Console.WriteLine($"Animal {i + 1}:");
//        //    Console.WriteLine("Ingrese el tipo (0 para Aéreo, 1 para Terrestre, 2 para Acuático):");
//        //    TipoAnimal tipo = (TipoAnimal)Enum.Parse(typeof(TipoAnimal), Console.ReadLine());

//        //    Console.WriteLine("Ingrese la cantidad de patas:");
//        //    int cantidadPatas = int.Parse(Console.ReadLine());

//        //    animales[i] = new Animal(tipo, cantidadPatas);
//        //}

//        //// Mostrar información
//        //foreach (var animal in animales)
//        //{
//        //    Console.WriteLine($"Tipo: {animal.Tipo}, Patas: {animal.CantidadPatas}");
//        //}



//        //string[] posiblesNombres =  { "Ana", "Juan", "Marta", "Carlos", "Laura", "Maria", "Pedro" };
//        //string[] posiblesApellidos =  { "García", "Fernández", "López" };
//        //string[] posiblesGruposSanguineos = { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };

//        //Persona[] personas = new Persona[10];

//        //Random random = new Random();

//        //for (int i = 0; i < personas.Length; i++)
//        //{
//        //    personas[i] = new Persona();
//        //    personas[i].Nombre = posiblesNombres[random.Next(posiblesNombres.Length)];
//        //    personas[i].Apellido = posiblesApellidos[random.Next(posiblesApellidos.Length)];
//        //    personas[i].Edad = random.Next(1,100);
//        //    personas[i].GrupoSanguineo = posiblesGruposSanguineos[random.Next(posiblesGruposSanguineos.Length)];
//        //}


//        //for (int i = 0; i < personas.Length; i++)
//        //{
//        //    for (int j = 0; j < personas.Length - i - 1; j++)
//        //    {
//        //        if (personas[j].Edad > personas[j + 1].Edad)
//        //        {
//        //            // Intercambiar personas[j] y personas[j + 1]
//        //            var temp = personas[j];
//        //            personas[j] = personas[j + 1];
//        //            personas[j + 1] = temp;
//        //        }
//        //    }
//        //}

//        //foreach (var item in personas)
//        //{
//        //    Console.WriteLine($" Soy {item.Nombre} {item.Apellido}, tengo " +
//        //        $"{item.Edad} años y mi sangre es {item.GrupoSanguineo} ");
//        //}

//        //Persona personaMenor = personas[0];
//        //Persona personaMayor = personas[personas.Length - 1];

//        //Console.WriteLine($"La persona más joven es {personaMenor.Nombre} {personaMenor.Apellido}, con {personaMenor.Edad} años");
//        //Console.WriteLine($"La persona más vieja es {personaMayor.Nombre} {personaMayor.Apellido}, con {personaMayor.Edad} años");



//        //var auto = new Auto("Toyota", "Corolla", 4, 50000);
//        //Console.WriteLine($"Auto: {auto.Marca} {auto.Modelo}, Puertas: {auto.CantidadPuertas}, Kms: {auto.KmsRecorridos}");

//        //var animal = new Animal(TipoAnimal.Terrestre, 4);
//        //Console.WriteLine($"Animal: {animal.Tipo}, Patas: {animal.CantidadPatas}");



//        //bool continuar = true;
//        //while (continuar)
//        //{
//        //    Console.WriteLine("\nAgencia de Viaje - Menú Principal");
//        //    Console.WriteLine("1- Calcular el total de un viaje.");
//        //    Console.WriteLine("2- Reservar pasajes.");
//        //    Console.WriteLine("3- Salir.");

//        //    Console.Write("Seleccione una opción: ");
//        //    int opcion = int.Parse(Console.ReadLine());

//        //    switch (opcion)
//        //    {
//        //        case 1:
//        //            CalcularTotalViaje();
//        //            break;
//        //        case 2:
//        //            ReservarPasajes();
//        //            break;
//        //        case 3:
//        //            continuar = false;
//        //            break;
//        //        default:
//        //            Console.WriteLine("Opción no válida.");
//        //            break;
//        //    }
//        //}
//        //bool continuar = true;
//        //int numero1 = 0;
//        //int numero2 = 0;

//        //while (continuar)
//        //{
//        //    Console.WriteLine("\nCalculadora del pueblo");
//        //    Console.WriteLine("1- Sumar.");
//        //    Console.WriteLine("2- Restar.");
//        //    Console.WriteLine("3- Multiplicar.");
//        //    Console.WriteLine("4- Dividir.");
//        //    Console.WriteLine("5- Salir.");

//        //    Console.Write("Seleccione una opción: ");
//        //    int opcion = int.Parse(Console.ReadLine());

//        //    if (opcion == 5)
//        //    {
//        //        continuar = false;
//        //                    Console.WriteLine("Saliendo...");
//        //                    continue;
//        //    }

//        //    if (opcion < 1 || opcion > 5)
//        //    {
//        //        Console.WriteLine("Opción no válida.");
//        //        continue;
//        //    }

//        //    Console.WriteLine("\nPor favor ingrese dos números");
//        //    numero1 = int.Parse(Console.ReadLine());
//        //    numero2 = int.Parse(Console.ReadLine());

//        //    switch (opcion)
//        //    {
//        //        case 1:
//        //            Sumar(numero1, numero2);
//        //            break;
//        //        case 2:
//        //            Restar(numero1, numero2);
//        //            break;
//        //        case 3:
//        //            Multiplicar(numero1, numero2);
//        //            break;
//        //        case 4:
//        //            Dividir(numero1, numero2);
//        //            break;
//        //        default:
//        //            Console.WriteLine("Opción no válida.");
//        //            break;
//        //    }
//        //}



//        //Console.Write("Ingrese la cantidad de remeras confeccionadas: ");
//        //int cantidadRemeras = int.Parse(Console.ReadLine());

//        //int totalHilo = RemerasConfeccionadas(cantidadRemeras);
//        //Console.WriteLine($"El total de hilo utilizado es: {totalHilo} metros");


//        //int resultado = Cuadrado(4);
//        //Console.WriteLine(resultado);

//        //Informacion("Kevin", 4);

//        //Console.WriteLine($"Valor inicial de la variable global: {variableGlobal}");

//        //ModificarVariableGlobal(10);

//        //Console.WriteLine($"Valor modificado de la variable global: {variableGlobal}");

//        //int resultado = Sumatoria(0);
//        //Console.WriteLine(resultado);

//        //int resultado = Resta(5, 2); 
//        //Console.WriteLine(resultado);

//        //string res = Unir("hola" , " mundo");
//        //Console.WriteLine(res);

//        //int resultadoFor = Factorial(4); // Debería devolver 24
//        //Console.WriteLine($"Factorial de 4 : {resultadoFor}");

//        //int resultadoWhile = Factorial(7); // Debería devolver 5040
//        //Console.WriteLine($"Factorial de 7 : {resultadoWhile}");


//        //Opciones();
//    }

//        //double[,] precios = new double[,] { { 50, 0 }, { 70, 0 }, { 100, 0 } };

//        ////double aumento = 0.10;
//        //Console.WriteLine("Ingrese el nuevo porcentaje de aumento (por ejemplo, 15 para un 15%): ");
//        //double nuevoAumento = double.Parse(Console.ReadLine()) / 100.0; // Convertir a porcentaje
//        //for (int i = 0; i < precios.GetLength(0); i++)
//        //{
//        //    precios[i, 1] = precios[i, 0] * (1 + nuevoAumento);
//        //}

//        //for (int i = 0;i < precios.GetLength(0); i++)
//        //{
//        //        Console.WriteLine((int)precios[i, 0]);
//        //        Console.WriteLine((int)precios[i, 1]);
//        //}

//        //// Mostrar los precios actualizados
//        //Console.WriteLine("Precios actualizados:");
//        //for (int i = 0; i < precios.GetLength(0); i++)
//        //{
//        //    Console.WriteLine($"Precio actual: ${precios[i, 0]}, Precio nuevo: ${precios[i, 1]:F2}");
//        //}


//        //int[,] calificaciones = new int[5, 3];
//        //Random notaRandom = new Random();

//        //// Llenar la matriz con calificaciones aleatorias del 1 al 10
//        //for (int i = 0; i < calificaciones.GetLength(0); i++)
//        //{ 
//        //    for (int j = 0; j < calificaciones.GetLength(1); j++)
//        //    { 
//        //        calificaciones[i, j] = notaRandom.Next(1, 11);
//        //    }
//        //}

//        //for (int i = 0; i < calificaciones.GetLength(0); i++)
//        //{
//        //    Console.Write($"Alumno {i + 1}: ");
//        //    for (int j = 0; j < calificaciones.GetLength(1); j++)
//        //    {
//        //        Console.Write(calificaciones[i, j] + " ");
//        //    }
//        //    Console.WriteLine();
//        //}

//        //for(int i = 0; i < calificaciones.GetLength(0); i++)
//        //{
//        //    double suma = 0;
//        //    for(int j = 0; j < calificaciones.GetLength(1); j++)
//        //    {
//        //        suma += calificaciones[i, j];
//        //    }
//        //    double promedio = suma / calificaciones.GetLength(1);
//        //    Console.WriteLine($"Promedio del alumno {i + 1}: {promedio:F2}");
//        //}

//        //for (int i = 0; i < calificaciones.GetLength(1); i++)
//        //{
//        //    double suma = 0;
//        //    for (int j = 0; j < calificaciones.GetLength(0); j++)
//        //    {
//        //        suma += calificaciones[j, i];
//        //    }
//        //    double promedio = suma / calificaciones.GetLength(0);
//        //    Console.WriteLine($"Promedio del calificaciones del examen numero {i + 1}: {promedio:F2}");
//        //}


//        //int[,] matriz = { { 4, 7, 9 }, { 2, 0, 7 }, { 8, 0, 1 } };

//        //Console.WriteLine(matriz[2,1]); 
//        //matriz[1,2] = 1;
//        //Console.WriteLine(matriz[1, 2]);

//        //int sumarDiagonal = 0;
//        //for (int i = 0; i < matriz.GetLength(0); i++)
//        //{
//        //    sumarDiagonal += matriz[i, i];
//        //}
//        //Console.WriteLine($"La suma de la diagonal principal es: {sumarDiagonal}");

//        //int suma = 0;
//        //for ( int i = 0;i < matriz.GetLength(0); i++)
//        //{
//        //    for (int j = 0; j < matriz.GetLength(1); j++)
//        //        suma += matriz[i,j];
//        //}
//        //        Console.WriteLine($"La suma total de la matriz da {suma}");

//        //int maximo = int.MinValue;

//        //for (int i = 0; i < matriz.GetLength(1); i++)
//        //{
//        //    if (matriz[0, i] > maximo)
//        //    {
//        //        maximo = matriz[0, i];
//        //    }
//        //}
//        //Console.WriteLine($"El valor máximo en la fila 1 es: {maximo}");

//        //for (int fila = 0; fila < matriz.GetLength(0); fila++)
//        //{
//        //    int maximoEnFila = int.MinValue;
//        //    int maximoEnColumna = int.MinValue;

//        //    for (int columna = 0; columna < matriz.GetLength(1); columna++)
//        //    {
//        //        if (matriz[fila, columna] > maximoEnFila)
//        //        {
//        //            maximoEnFila = matriz[fila, columna];
//        //        }

//        //        if (matriz[columna, fila] > maximoEnColumna)
//        //        {
//        //            maximoEnColumna = matriz[columna, fila];
//        //        }
//        //    }

//        //    Console.WriteLine($"El valor máximo en la fila {fila+1} es: {maximoEnFila}");
//        //    Console.WriteLine($"El valor maximo de la columna {fila + 1} es {maximoEnColumna}");
//        //}



//        //int[,] transpuesta = new int[matriz.GetLength(1), matriz.GetLength(0)];
//        //for (int i = 0; i < matriz.GetLength(0); i++)
//        //    for (int j = 0; j < matriz.GetLength(1); j++)
//        //        transpuesta[j, i] = matriz[i, j];

//        //for (int i = 0; i < matriz.GetLength(0); i++)
//        //{
//        //    for (int j = 0; j < matriz.GetLength(1); j++)
//        //    {
//        //        Console.Write(matriz[i, j] + (j == matriz.GetLength(1) - 1
//        //            ? "\n" : ", "));
//        //    }
//        //}

//        //for (int i = 0; i < transpuesta.GetLength(0); i++)
//        //{
//        //    for (int j = 0; j < transpuesta.GetLength(1); j++)
//        //    {
//        //        Console.Write(transpuesta[i, j] + (j == transpuesta.GetLength(1) - 1
//        //            ? "\n" : ", "));
//        //    }
//        //}

//        //int suma = 0;
//        //for (int i = 0; i < matriz.GetLength(0); i++)
//        //    for (int j = 0; j < matriz.GetLength(1); j++)
//        //        suma += matriz[i, j];

//        //int buscado = 0;
//        //Console.WriteLine("Ingresa un numero valido");
//        //buscado = int.Parse(Console.ReadLine());
//        //bool encontrado = false;
//        //for (int i = 0; i < matriz.GetLength(0); i++)
//        //{

//        //    for (int j = 0; j < matriz.GetLength(1); j++)
//        //    {
//        //        Console.WriteLine($"El numero: {matriz[i,j]} el cual se " +
//        //            $"encuentra en la fila {i} de la columna {j} " +
//        //            $"no coincide con el numero {buscado} ");
//        //        if (matriz[i, j] == buscado)
//        //        {
//        //            encontrado = true;
//        //            break;
//        //        }
//        //    }
//        //    if (encontrado) break;
//        //}

//        //if (encontrado)
//        //{
//        //    Console.WriteLine($"Número {buscado} encontrado en la matriz.");
//        //}
//        //else
//        //{
//        //    Console.WriteLine($"Número {buscado} no encontrado en la matriz.");
//        //}



//    }
//}