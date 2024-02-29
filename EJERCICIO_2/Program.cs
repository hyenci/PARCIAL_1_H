Console.WriteLine("**************");
Console.WriteLine("PROGRAMA NO.4");
Console.WriteLine("**************");
Console.WriteLine("");
int opis = 0;
int numsecre = 21;
do
{

    if (opis < numsecre)
    {

        Console.WriteLine("Su numero ingresado es menor al numero secreto");


    }
    else if (opis > numsecre)
    {
        Console.WriteLine("Su numero ingresado es mayor al numero secreto");
    }
    else
    {
        Console.WriteLine("¡FELICIDADES HA ENCONTRADO EL NUMERO SECRETO¡");
    }



}
while (opis != 21);

Console.WriteLine("TOCA UNA TECLA PARA VOLVER AL MENU PRINCIPAL");