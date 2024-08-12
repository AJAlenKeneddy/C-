Console.WriteLine("¿Cual es tu nombre?");
var nombre= Console.ReadLine();
var fechayhoraactual= DateTime.Now;


Console.WriteLine($"{Environment.NewLine}Hola, {nombre}, hoy es: {fechayhoraactual}");
Console.WriteLine($"{Environment.NewLine}Presiona Cualquier Techa para detener la ejecucion ");
Console.ReadKey(true);

