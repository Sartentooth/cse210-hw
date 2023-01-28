using System;

class Program
{
    static void Main(string[] args)
    {
       int posX, posY;
 
        Console.Title = "Ejemplo de consola";
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
 
        posY = 10;  // En la fila 10
        Random r = new Random(DateTime.Now.Millisecond);
        posX = r.Next(20, 40); // Columna al azar entre 20 y 40
        Console.SetCursorPosition(posX, posY);
        Console.WriteLine("Bienvenido");
 
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(10, 15);
        Console.Write("Pulsa 1 o 2: ");
        ConsoleKeyInfo tecla;
        do 
        {
            tecla = Console.ReadKey(false);
        } 
        while ((tecla.KeyChar != '1') && (tecla.KeyChar != '2'));
 
        int maxY = Console.WindowHeight;
        int maxX = Console.WindowWidth;
        Console.SetCursorPosition(maxX-50, maxY-1);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Pulsa una tecla para terminar... ");    
        Console.ReadKey(true);
    }  
}