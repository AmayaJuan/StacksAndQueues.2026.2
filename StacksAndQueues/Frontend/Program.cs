using Backend;
// Stack usibg a list
//var stack = new StackUsingList<string>();
// Stack using an array
//var stack = new StackUsingArray<string>(10);
// Stack from .NET Framework
var stack = new Stack<string>();

// Demo for "inifinite" for stack| in a list
//var random = new Random();

//while (true)
//{
// stack.Push(random.Next());
// Console.WriteLine(stack.Peek());
//}

var option = string.Empty;
do
{
    try
    {
        option = Menu();
        switch (option)
        {
            case "1":
                Console.Write("Digite el elemento: ");
                stack.Push(Console.ReadLine()!);
                break;
            case "2":
                Console.WriteLine($"Elemento desapilado: {stack.Pop()}");
                break;
            case "3":
                Console.WriteLine($"Elemento en el tope de la pila: {stack.Peek()}");
                break;
            case "0":
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción no inválida.");
                break;
        }

    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ForegroundColor = ConsoleColor.White;
    }
} while (option != "0");

string Menu()
{
    Console.WriteLine("1. Apilar");
    Console.WriteLine("2. Desapilar");
    Console.WriteLine("3. Ver tope de la pila");
    Console.WriteLine("0. Salir");
    Console.Write("Digite su opción: ");
    return Console.ReadLine()!;
}

