

// metodos importantes
//ToLower = convierte todos los valores de una cadena en minusculoa.
//ToUpper = convierte todos los valores en mayúscula.

var  controlJuego = default(bool);

while (!controlJuego)
{
    Console.WriteLine("Juego de Piedra Papel o Tijera\n");

    Console.WriteLine("Estas listo!");
    Console.WriteLine("Vayamos!");
    var opcionseleccionada = opcionSeleccionada();

   


    var valorEscogido = char.Parse(opcionseleccionada);

    Console.WriteLine($"El valor escogido fue {valorEscogido}");

    var valorComputadora = getEleccionOponente();
    Console.WriteLine($"yo escojo {valorComputadora}");

    escogerGanador(valorEscogido, valorComputadora);

    Console.WriteLine("Desea seguir jugando?");
    Console.WriteLine("presione YES para seguir jugando u otra tecla para cerrar");
    var nuevoJuego = Console.ReadLine();
    if(nuevoJuego?.ToLower() == "yes")
    {
        Console.Clear();
        continue;
    }
    else
    {
        break;
    }



}

string opcionSeleccionada()
{
    Console.WriteLine("Escoja I , P o T :  p[I]edra , [P]apel , [T]ijeras");
    var opcionseleccionada = Console.ReadLine();

    if(opcionseleccionada?.ToLower() != "i" && opcionseleccionada?.ToLower() != "p" && opcionseleccionada?.ToLower() != "t")
    {
        Console.WriteLine("Por favor, Elija una letra: I,P o T ");
        //recursividad
        opcionseleccionada = opcionSeleccionada();


    }

    return opcionseleccionada;
}


char getEleccionOponente()
{

    char[] opciones = new char[] { 'I', 'P', 'T' };

    Random random = new Random();

    int randomindice = random.Next(0,opciones.Length);
    return opciones[randomindice];
}

void escogerGanador(char valorEscogido , char valorComputadora)
{
       if(valorEscogido == Char.ToLower(valorComputadora)) { 
        Console.WriteLine("Empate");
        return;
        }
    switch (valorEscogido)
    {
        case 'I':
        case 'i':
            if (valorComputadora == 'P')
            
                Console.WriteLine("Papel envuelve a Piedra , yo Gané!");
             else if(valorComputadora == 'T')
                
                    Console.WriteLine("Piedra rompe a Tijera , Felicidades  Tu Ganáste!");
                
            
            break;

        case 'T':
        case 't':
            if (valorComputadora == 'P')
            
                Console.WriteLine("Tijera corta a papel , Felicidades tu ganáste!");
            
            else
            
                if (valorComputadora == 'I')
                
                    Console.WriteLine("piedra le gana a tijera, Yo Gané! ");
                
            
            break;

        case 'P':
        case 'p':
            if (valorComputadora == 'T')
            
                Console.WriteLine("Tijera corta a papel , Yo Gané!");
            
            else
            
                if (valorComputadora == 'I')
                
                    Console.WriteLine("papel le gana a la piedra, tu Ganáste! ");
                
            
            break;

    }


    
   

}