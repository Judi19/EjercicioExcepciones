using EjercicioExcepciones;

Operaciones operaciones = new Operaciones();
bool continuar = true;

while (continuar)
{
    Console.WriteLine("Seleccione una opción: ");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");

    try
    {
        int opcion = int.Parse(Console.ReadLine());
        if (opcion == 5)
        {
            continuar = false;
            continue;
        }

        Console.WriteLine("Ingrese el primer dígito: ");
        double Digito1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo dígito: ");
        double Digito2 = double.Parse(Console.ReadLine());
        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = operaciones.Sumar(Digito1, Digito2);
                break;

            case 2:
                resultado = operaciones.Restar(Digito1, Digito2);
                break;

            case 3:
                resultado = operaciones.Multiplicar(Digito1, Digito2);
                break;

            case 4:
                resultado = operaciones.Dividir(Digito1, Digito2);
                break;

            default:
                Console.WriteLine("Opción no válida");
                continue;
        }
        Console.WriteLine($"El resultado es: {resultado}");
        Console.WriteLine();
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}