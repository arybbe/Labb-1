//Skapa en konsollapplikation som tar en textsträng (string)
//som argument till Main eller uppmanar användaren mata in en sträng i konsollen.
//Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
//och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
//siffror förekommer där emellan.
//ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
//ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
//t.ex 95a9 är inte heller ett korrekt tal.
//För varje sådan delsträng som matchar kriteriet ovan ska programmet skriva ut en
//rad med hela strängen, men där delsträngen är markerad i en annan färg.
//Exempel output för input ”29535123p48723487597645723645”:
//Programmet ska också addera ihop alla tal den hittat enligt ovan och skriva ut det
//sist i programmet. Gör gärna en tom rad emellan för att skilja från output ovan.
//Exempel output för input ”29535123p48723487597645723645”:
//Total = 5836428677242

Console.Write("Skriv in en sträng: ");
string bigNumber = Console.ReadLine();
int subStringinNumbers = 0;
int index = -1;

string[] listofBigNumber = new string[bigNumber.Length];

for (int i = 0; i < bigNumber.Length; i++)
{
    char c = bigNumber[i];
    if (char.IsDigit(c))
    {
        subStringinNumbers += c;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(subStringinNumbers);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(bigNumber);
        Console.WriteLine();
    }
        
}
  