//1)    Cartón de 3 filas por 9 columnas
//2)    El cartón debe tener 15 números y 12 espacios en blanco
//3)    Cada fila debe tener 5 números
//4)    Cada columna debe tener 1 o 2 números
//5)    Ningún número puede repetirse
//6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
//7)    Mostrar el carton por pantalla


using static System.Console;
Clear();


string[,] carton = new string[3, 9];
Random aleatorio1 = new Random();
Random aleatorio2 = new Random();



for (int i = 0; i == 0; i++)
{

    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = aleatorio1.Next(1, 9).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = aleatorio1.Next(1, 9).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }

    }
}

for (int i = 1; i == 1; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = aleatorio1.Next(10, 19).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = aleatorio1.Next(10, 19).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }
    }
}

for (int i = 2; i == 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = aleatorio1.Next(20, 29).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = aleatorio1.Next(20, 29).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }
    }
}

for (int i = 3; i == 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = aleatorio1.Next(30, 39).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = aleatorio1.Next(30, 39).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }
    }
}

for (int i = 4; i == 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = aleatorio1.Next(40, 49).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = aleatorio1.Next(40, 49).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }
    }
}

for (int i = 5; i == 5; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = aleatorio1.Next(50, 59).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = aleatorio1.Next(50, 59).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }

    }
}

for (int i = 6; i == 6; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = aleatorio1.Next(60, 69).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = aleatorio1.Next(60, 69).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }
    }
}

for (int i = 7; i == 7; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = aleatorio1.Next(70, 79).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = aleatorio1.Next(70, 79).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }
    }
}

for (int i = 8; i == 8; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = aleatorio1.Next(80, 90).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = aleatorio1.Next(80, 90).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }
    }
}





for (int j = 0; j == 0; j++)
{
    int space = aleatorio2.Next(1, 2);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 0; j == 0; j++)
{
    int space = aleatorio2.Next(4, 5);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 0; j == 0; j++)
{
    int space = aleatorio2.Next(6, 7);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 0; j == 0; j++)
{
    int space = aleatorio2.Next(7, 9);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 1; j == 1; j++)
{
    int space = aleatorio2.Next(0, 1);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 1; j == 1; j++)
{
    int space = aleatorio2.Next(3, 4);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}



for (int j = 1; j == 1; j++)
{
    int space = aleatorio2.Next(2, 3);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 1; j == 1; j++)
{
    int space = aleatorio2.Next(5, 9);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}


for (int j = 2; j == 2; j++)
{
    int space = aleatorio2.Next(5, 6);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 2; j == 2; j++)
{
    int space = aleatorio2.Next(7, 8);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 2; j == 2; j++)
{
    int space = aleatorio2.Next(8, 9);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 2; j == 2; j++)
{
    int space = aleatorio2.Next(0, 5);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}



WriteLine("****** CARTON 1 ******");
for (int j = 0; j < 3; j++)
{
    for (int i = 0; i < 9; i++)
    {

        Write($"|| {carton[j, i]} || ");


    }
    WriteLine();
}



WriteLine();
WriteLine("=================================================================================================================================");
WriteLine();


string[,] carton2 = new string[3, 9];
Random aleat1 = new Random();
Random aleat2 = new Random();



for (int i = 0; i == 0; i++)
{

    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = aleat1.Next(1, 9).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = aleat1.Next(1, 9).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }

    }
}

for (int i = 1; i == 1; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = aleat1.Next(10, 19).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = aleat1.Next(10, 19).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }
    }
}

for (int i = 2; i == 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = aleat1.Next(20, 29).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = aleat1.Next(20, 29).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }
    }
}

for (int i = 3; i == 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = aleat1.Next(30, 39).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = aleat1.Next(30, 39).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }
    }
}

for (int i = 4; i == 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = aleat1.Next(40, 49).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = aleat1.Next(40, 49).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }
    }
}

for (int i = 5; i == 5; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = aleat1.Next(50, 59).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = aleat1.Next(50, 59).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }

    }
}

for (int i = 6; i == 6; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = aleat1.Next(60, 69).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = aleat1.Next(60, 69).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }
    }
}

for (int i = 7; i == 7; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = aleat1.Next(70, 79).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = aleat1.Next(70, 79).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }
    }
}

for (int i = 8; i == 8; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = aleat1.Next(80, 90).ToString();
        bool boleano = true;
        while (boleano == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = aleat1.Next(80, 90).ToString();
                    l = -1;
                }
            }
            boleano = false;
        }
    }
}



for (int j = 0; j == 0; j++)
{
    int space = aleat2.Next(1, 2);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 0; j == 0; j++)
{
    int space = aleat2.Next(4, 5);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 0; j == 0; j++)
{
    int space = aleat2.Next(6, 7);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 0; j == 0; j++)
{
    int space = aleat2.Next(7, 9);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}


for (int j = 1; j == 1; j++)
{
    int space = aleat2.Next(0, 1);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 1; j == 1; j++)
{
    int space = aleat2.Next(3, 4);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}



for (int j = 1; j == 1; j++)
{
    int space = aleat2.Next(2, 3);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 1; j == 1; j++)
{
    int space = aleat2.Next(5, 9);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}


for (int j = 2; j == 2; j++)
{
    int space = aleat2.Next(5, 6);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 2; j == 2; j++)
{
    int space = aleat2.Next(7, 8);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 2; j == 2; j++)
{
    int space = aleat2.Next(8, 9);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 2; j == 2; j++)
{
    int space = aleat2.Next(0, 5);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}



WriteLine("****** CARTON 2 ******");
for (int j = 0; j < 3; j++)
{
    for (int i = 0; i < 9; i++)
    {

        Write($"|| {carton2[j, i]} || ");


    }
    WriteLine();
}