// Prosta aplikacja wykonujace pseudolosowe rzuty wybrana koscia


char choice;
//char choice uzywamy gdy chcemy zrobic wybor jednym kliknieciem

Random rng = new Random();
//Random bedzie potrzebny do wybierania randomowych liczb

do
{
    //wszystkie writeline to nasze menu 
    Console.WriteLine("Jaką kością chcesz rzucić: ");
    Console.WriteLine("1. K3");
    Console.WriteLine("2. K4");
    Console.WriteLine("3. K6");
    Console.WriteLine("4. K100");
    Console.WriteLine("0. Wyjscie");
    choice = Console.ReadKey(true).KeyChar;
    //choice komenda gdy klikamy wybrany numerek odrazu odpala program
    //switch nasz program z wyborami
    switch (choice)
    {
        case '1':
            //case z  '' uzywamy tych apostrofów do redkeya
            //consolewriteline nasz komuniukat o wyniku rng wybor naszej opcji z menu z podanym zakresem 
            //break przerywa nie zapetla 
            // jesli podano 1
            Console.WriteLine("Wynik rzutu K3: " + rng.Next(1, 3));
            break;
        case '2':
            //case z  '' uzywamy tych apostrofów do redkeya
            //consolewriteline nasz komuniukat o wyniku rng wybor naszej opcji z menu z podanym zakresem 
            //break przerywa nie zapetla 
            // jesli podano 2
            Console.WriteLine("Wynik rzutu K3: " + rng.Next(1, 4));
            break;
        case '3':
            //case z  '' uzywamy tych apostrofów do redkeya
            //consolewriteline nasz komuniukat o wyniku rng wybor naszej opcji z menu z podanym zakresem 
            //break przerywa nie zapetla 
            //jesli podano 3
            Console.WriteLine("Wynik rzutu K3: " + rng.Next(1, 6));
            break;
        case '4':
            //case z  '' uzywamy tych apostrofów do redkeya
            //consolewriteline nasz komuniukat o wyniku rng wybor naszej opcji z menu z podanym zakresem 
            //break przerywa nie zapetla 
            // jesli podano 4
            Console.WriteLine("Wynik rzutu K3: " + rng.Next(1, 100));
            break;
        case '0':
            //jesli podano 0
            //zamyka program/ petle
            Console.WriteLine("Zamykanie programu");
            break;
        default:
            //wykona sie jesli zaden wczesniejszy nie pasuje
            Console.WriteLine("Podano nieprawidłową opcję!");
            break;
    }
}
//jesli wybierzemy opcje
while (choice != '0');


