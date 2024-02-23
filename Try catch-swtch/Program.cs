/*Try catch
Calcular el mayor de tres numeros*/
try
{
    string num1, num2, num3;
    decimal n1, n2, n3;
    Console.WriteLine("Ingrese el primer numero");
    num1 = Console.ReadLine();
    while (!decimal.TryParse(num1, out n1))
    {
        Console.WriteLine("El numero se ingreso en letras cuando deberia ser en numeros");
        num1 = Console.ReadLine();
    }
    Console.WriteLine("Ingrese el segundo numero");
    num2 = Console.ReadLine();
    while (!decimal.TryParse(num2, out n2))
    {
        Console.WriteLine("El numero se ingreso en letras cuando deberia ser en numeros");
        num2 = Console.ReadLine();
    }
    Console.WriteLine("Ingrese el tercer numero");
    num3 = Console.ReadLine();
    while (!decimal.TryParse(num3, out n3))
    {
        Console.WriteLine("El numero se ingreso en letras cuando deberia ser en numeros");
        num3 = Console.ReadLine();
    }

    decimal mayo = Math.Max(n1, Math.Max(n2, n3));
    Console.WriteLine("El numero mayor es: " + mayo);
}
catch (Exception error)
{ Console.WriteLine(error.Message); }

/*validacion de edad*/

try
{
    int edad;
    Console.WriteLine("Si desea entrar al club ingrese su edad: ");
    edad = Convert.ToInt32(Console.ReadLine().ToUpper());
    if (edad >= 18 )
    {
        Console.WriteLine("Ud. cumple con los requisitos, puede pasar");
    }
    else
    {
        Console.WriteLine("No cumple con los requisitos, no puede pasar");
    }
}
catch (Exception error) {  Console.WriteLine(error.Message); }  

/*PRECIO FINAL DE UN PRODUCTO*/

try
{
    decimal po, pd;
    Console.WriteLine("Ingrese el precio original del producto ");
    po = decimal.Parse(Console.ReadLine());
    if (po > 100)
    {
        pd = po * 0.10m;
        decimal des = po - pd;
        Console.WriteLine("El precio original es de " + po);
        Console.WriteLine("El precio final es de: " + des);
    }
    Console.WriteLine("El precio original es menor o igual a 100.Q, no obtiene descuento");
}
catch (Exception error) { Console.WriteLine(error.Message); } 

/*Validar Usuario y Contrasena*/

try
{
    Console.WriteLine("Ingrese su nombre de usuario");
    string usua=Console.ReadLine();
    Console.WriteLine("Ingrese su contraseña");
    int contra = int.Parse(Console.ReadLine());
    while (usua != "Mario" && contra != 2341)
    {
        Console.WriteLine("Nombre de usuario o contraseña incorrectos, por favor ingreselos correctamente");
        usua=Console.ReadLine();
        contra= int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Ha ingresado sesión correctamente");
}
catch (Exception error) { Console.WriteLine(error.Message); } 

/* Determinar si un numero es par o impar*/

try
{
    Console.WriteLine("Ingrese el numero que desea saber si es par o impar");
    int par = int.Parse(Console.ReadLine());
    int sab = par % 2;
    if (sab ==0)
    {
        Console.WriteLine("El numero ingresado es par");
    }
    else
    {
        Console.WriteLine("El numero ingresado es impar");
    }
    
}
catch (Exception error) { Console.WriteLine(error.Message); } 

/*Aprobacion o rechazo del prestamo*/

try
{
    Console.WriteLine("Ingrese su edad: ");
    int ed = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el monto del prestamo que desea obtener: ");
    decimal monto = decimal.Parse(Console.ReadLine());
    if(monto<5000 || ed > 60)
    {
        Console.WriteLine("Usted es apto para el prestamo");
    }
    else
    {
        Console.WriteLine("Usted no es apto para el prestamo");
    }
}
catch ( Exception error) { Console.WriteLine(error.Message); }


/*Area de una figura geometrica*/

try
{
    Console.WriteLine("Ingrese la figura geometrica");
    string fig= Console.ReadLine();

    if(fig == "Triángulo")
    {
        Console.WriteLine("Ingrese la base: ");
        decimal bas =decimal.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la altura: ");
        decimal altu = decimal.Parse(Console.ReadLine());
        decimal area = bas * altu / 2m;
        Console.WriteLine("La base del triángulo es: "+area);

    }
    if (fig == "Cuadrado")
    {
        Console.WriteLine("Ingrse la medida de los 4 lados del Cuadrado: ");
        decimal l1 = decimal.Parse(Console.ReadLine());
        decimal l2 = decimal.Parse(Console.ReadLine());
        decimal l3 = decimal.Parse(Console.ReadLine());
        decimal l4 = decimal.Parse(Console.ReadLine());
        decimal area= l1 * l2 + l3 * l4;
        Console.WriteLine("La base del cuadrado es: " + area);
    }
    if (fig == "Círculo")
    {
        Console.WriteLine("Ingrse el radio del círculo : ");
        double rad= double.Parse(Console.ReadLine());
        double area = 3.1416*(Math.Pow(rad, 2));
        Console.WriteLine("La base del círculo es: " + area);
    }

}
catch(Exception error) { }

/*Un numero en letras a numeros*/

try
{
    Console.WriteLine("Ingrese un numero del 1 al 5 en letras: ");
    string let = Console.ReadLine().ToLower();

    switch (let){
        case "uno":
            Console.WriteLine(let+"_1");
        break;
        case "dos":
            Console.WriteLine(let + "_2");
            break;
        case "tres":
            Console.WriteLine(let + "_3");
            break;
        case "cuatro":
            Console.WriteLine(let + "_4");
            break;
        case "cinco":
            Console.WriteLine(let + "_5");
            break;
        default:
            Console.WriteLine("Valor no valido");
            break;
    }
}
catch (Exception error) { }

/*Dia de la semana a partir de un numero*/

try
{
    Console.WriteLine("Ingrese un numemero del 1 al 7: ");
    int dia = int.Parse(Console.ReadLine());
    switch (dia)
    {
        case 1:
            Console.WriteLine("Lunes");
            break;
        case 2:
            Console.WriteLine("Martes");
            break;
        case 3:
            Console.WriteLine("Miercoles");
            break;
        case 4:
            Console.WriteLine("Jueves");
            break;
        case 5:
            Console.WriteLine("Viernes");
            break;
        case 6:
            Console.WriteLine("Sabado");
            break;
        case 7:
            Console.WriteLine("Domingo");
            break;
        default:
            Console.WriteLine("Valor no valido");
            break;
    }
}
catch (Exception error) { }

/*Calcular el importe a pagar*/

try
{
    Console.WriteLine("Seleccione el servicio que desea(1,2 o 3)");
    Console.WriteLine("1) Lavado de Auto");
    Console.WriteLine("2) Cambio de Aceite");
    Console.WriteLine("3) Revision de Equipo");
    int serv = int.Parse(Console.ReadLine());
    switch (serv)
    {
        case 1:
            Console.WriteLine("El coste por el lavado de auto es de Q.100");
            break;
            case 2:
            Console.WriteLine("El coste por el cambio de aceite es de Q.200");
            break;
            case 3:
            Console.WriteLine("El coste por la revision de equipo es de Q.300");
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
}
catch(Exception error) { }

/*Mensaje de bienbenida*/

try
{
    Console.WriteLine("Seleccione el idioma de su preferencia: (1,2 o 3");
    Console.WriteLine("1.) Español");
    Console.WriteLine("2) English");
    Console.WriteLine("3) Français");
    int idio = int.Parse(Console.ReadLine());
    switch(idio)
    {
        case 1:
            Console.WriteLine("¡Bienvenido!");
            break;
        case 2: Console.WriteLine("Welcome");
            break;
        case 3:
            Console.WriteLine("Accueillir!");
            break;
        default:
        Console.WriteLine("Opcion no valida");
        break;
    }

}
catch(Exception error) { }

/*Evaluar calificacion de un Examen*/

try
{
    Console.WriteLine("Ingrese la nota de su examen (en numeros)");
    int cali=int.Parse(Console.ReadLine());
    switch (cali)
    {
        case <69:
            Console.WriteLine("Ni modo, toca sacrificar al mas chaparro del grupo para hacer la remontada");
            break;
        case >= 70 and <=79:
            Console.WriteLine("Peor es tener que ir a recuperacion");
            break;
        case >= 80 and <= 89:
            Console.WriteLine("EN HORA BUENA! ahora nadie podra decirte tonto");
            break;
        case >= 90 and <= 100:
            Console.WriteLine("Bro, tienes un IQ mayor al promedio");
            break;
        default: Console.WriteLine("Nota no valida");
                break;
    }
}
catch(Exception error) { }