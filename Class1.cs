using System;
using static Program;

internal class Program
{

    public record Contratista
    {
        public int Codigo { get; set; }
        public int CantidadContratos { get; set; }
        public int[] ImporteContrato { get; set; }
        public int? ImportePorCantidad { get; set; }
    }

    static void Main(string[] args)
    {

        Random r = new Random();

        ////Ejercio 1

        int[,] tablero = new int[3, 3];
        int aciertos = 0;
        int intentos = 3;

        while (intentos > 0)
        {

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    tablero[i, j] = 0;
                }
            }

            int cantidadBarcos = r.Next(1, 10);
            int barcosColocados = 0;
           
            while (barcosColocados < cantidadBarcos)
            {
                int filaBarco = r.Next(3);
                int columnaBarco = r.Next(3);

                if (tablero[filaBarco, columnaBarco] == 0)
                {
                    tablero[filaBarco, columnaBarco] = 1;
                    barcosColocados++;
                }
            }

            Console.WriteLine($"{intentos} intento/s restantes : Ingresa fila y columna (1 a 3):");
            Console.Write("Fila: ");
            int filaUsuario = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Columna: ");
            int columnaUsuario = Convert.ToInt32(Console.ReadLine()) - 1;

            if (filaUsuario >= 0 && filaUsuario < 3 && columnaUsuario >= 0 && columnaUsuario < 3)
            {
                intentos--;
                if (tablero[filaUsuario, columnaUsuario] == 1)
                {
                    Console.WriteLine("¡Acertaste!");
                    aciertos++;
                }
                else
                {
                    Console.WriteLine("Fallaste.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debes ingresar números del 1 al 3.");
            }

        }

        if (aciertos >= 2)
        {
            Console.WriteLine("¡Ganaste! Derribaste " + aciertos + " barcos.");
        }
        else
        {
            Console.WriteLine("Perdiste. No derribaste los barcos necesarios.");
        }

        Console.WriteLine();

        ////Ejercicio 2

        int cantidadBilletesDia;
        int totalBilletes = 0;
        int supero1500 = 0;
        int excesoBilletes = 0;
        int dias = 30;

        for (int i = 0; i < dias; i++)
        {
            cantidadBilletesDia = r.Next(1000, 3001);
            totalBilletes += cantidadBilletesDia;

            if (cantidadBilletesDia > 1500)
            {
                supero1500++;
            }

            if (cantidadBilletesDia > 2000)
            {
                excesoBilletes += cantidadBilletesDia - 2000;
            }

        }
        int promedioBilletes = totalBilletes / 30;

        Console.WriteLine("Cantidad de billetes promedio en la caja: " + promedioBilletes);
        Console.WriteLine("Cantidad de días que superaron los 1500 billetes: " + supero1500);
        Console.WriteLine("Total de billetes que excedieron el tope de 2000: " + excesoBilletes);

        Console.WriteLine();

        //Ejercicio 3

        int[] numeros = new int[] { 1, 4, 3, 2, 7, 6 };
        int min1 = int.MaxValue, min2 = int.MaxValue;
        int posMin1 = -1, posMin2 = -1;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] < min1)
            {
                min1 = numeros[i];
                posMin1 = i;
            }
            else if (numeros[i] < min2)
            {
                min2 = numeros[i];
                posMin2 = i;
            }
        }

        Console.WriteLine($"Los dos numeros mas pequeños son el {min1} en la posicion {posMin1} y el {min2} en la posicion {posMin2}");

        Console.WriteLine();

        //Ejercicio 4

        Contratista[] contratistas = new Contratista[8];

        for (int i = 0; i < contratistas.Length; i++)
        {
            int cantidadContratos = r.Next(5, 11);
            int[] importeContrato = new int[cantidadContratos];

            for (int j = 0; j < cantidadContratos; j++)
            {
                importeContrato[j] = r.Next(1000, 5001);
            }



            contratistas[i] = new Contratista { Codigo = i + 1, CantidadContratos = cantidadContratos, ImporteContrato = importeContrato };
        }

        Array.ForEach(contratistas, contratista => contratista.ImportePorCantidad = contratista.ImporteContrato.Sum());

        Contratista[] contratistaMenor21000 = Array.FindAll(contratistas, contratista => contratista.ImportePorCantidad < 21000);

        foreach (var item in contratistaMenor21000)
        {
            Console.WriteLine($"Codigo: {item.Codigo}, CantidadContratos: {item.CantidadContratos}, ImportePorCantidad: {item.ImportePorCantidad}");
            Console.WriteLine("Importes de los contratos:");
            foreach (var importe in item.ImporteContrato)
            {
                Console.WriteLine(importe);
            }
        }
   

    }
    }
