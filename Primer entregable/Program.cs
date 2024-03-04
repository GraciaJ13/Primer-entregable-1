//Punto 1

/*
int opcion;
int nume1, nume2, deno1, deno2, numerador, denominador;
Console.WriteLine("Ingrese el numero correspondiente a la operacion que desee calcular: \n" +
"1.Suma \n" +
"2.Resta \n" +
"3.Multiplicacion \n" +
"4.Division \n");
opcion = int.Parse(Console.ReadLine());
switch (opcion)
{
    case 1:
        Console.WriteLine("Ingrese la primera fracción:");
        Console.WriteLine("Ingrese un valor de numerador: ");
        nume1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un valor del denominador: ");
        deno1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la segunda fracción:");
        Console.WriteLine("Ingrese un valor de numerador: ");
        nume2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un valor del denominador: ");
        deno2 = int.Parse(Console.ReadLine());
        numerador = (nume1 * deno2) + (deno1 * nume2);
        denominador = (deno1 * deno2);
        Console.WriteLine("El resultado es: " + numerador + "/" + denominador);
        break;
    case 2:
        Console.WriteLine("Ingrese la primera fracción:");
        Console.WriteLine("Ingrese un valor de numerador: ");
        nume1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un valor del denominador: ");
        deno1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la segunda fracción:");
        Console.WriteLine("Ingrese un valor de numerador: ");
        nume2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un valor del denominador: ");
        deno2 = int.Parse(Console.ReadLine());
        numerador = (nume1 * deno2) - (deno1 * nume2);
        denominador = (deno1 * deno2);
        Console.WriteLine("El resultado es: " + numerador + "/" + denominador);
        break;
    case 3:
        Console.WriteLine("Ingrese la primera fracción:");
        Console.WriteLine("Ingrese un valor de numerador: ");
        nume1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un valor del denominador: ");
        deno1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la segunda fracción:");
        Console.WriteLine("Ingrese un valor de numerador: ");
        nume2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un valor del denominador: ");
        deno2 = int.Parse(Console.ReadLine());
        numerador = (nume1 * nume2);
        denominador = (deno1 * deno2);
        Console.WriteLine("El resultado es: " + numerador + "/" + denominador);
        break;
    case 4:
        Console.WriteLine("Ingrese la primera fracción:");
        Console.WriteLine("Ingrese un valor de numerador: ");
        nume1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un valor del denominador: ");
        deno1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la segunda fracción:");
        Console.WriteLine("Ingrese un valor de numerador: ");
        nume2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un valor del denominador: ");
        deno2 = int.Parse(Console.ReadLine());
        numerador = (nume1 * deno2);
        denominador = (deno1 * nume2);
        Console.WriteLine("El resultado es: " + numerador + "/" + denominador);
        break;

    default:
        Console.WriteLine("Dato erroneo");
        break;

}
*/


//Punto 2

/*

Console.WriteLine("Ingrese un número para determinar si es divisible entre 5");
int number = int.Parse(Console.ReadLine());
if (number % 5 == 0){
    Console.WriteLine("Es un numero especial");
}
else{
    Console.WriteLine("No es un numero especial");
}

*/

//Punto 3

/*

Console.WriteLine("Ingrese su edad ");
int age = int.Parse(Console.ReadLine());

int days = (age*365);
int year = (age/4)+1;
int sem = age*52;
int total= days+year;


Console.WriteLine("Han transcurrido " + total + " dias desde su nacimiento y " + sem + " semanas");

*/

//Punto 4

/*
string password;
string user;
int cont = 0; // Inicializamos el contador en 0

string usuarioPredefinido = "admin";
string contraseñaPredefinida = "12345";

do
{
    Console.WriteLine("Ingrese el usuario:");
    user = Console.ReadLine();
    Console.WriteLine("Ingrese la contraseña:");
    password = Console.ReadLine();
    cont++;

    if (password != contraseñaPredefinida || user != usuarioPredefinido)
    {
        Console.WriteLine("\nUsuario o Contraseña incorrectos.");
        Console.WriteLine("Intentos restantes: " + (3 - cont)); // Mostramos los intentos restantes
        if (cont >= 3)
        {
            Console.WriteLine("Acceso denegado.");
            return;
        }
        Console.WriteLine("Intente nuevamente.\n");
    }
    else
    {
        Console.WriteLine("\nAcceso concedido.");
        return;
    }
} while (cont < 3);

*/

