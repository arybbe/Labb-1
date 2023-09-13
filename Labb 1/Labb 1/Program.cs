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
string inputNumber = Console.ReadLine();

string subString = "";
string beforeSubString = "";
string endSubString = "";

long summaryOfAllSubStrings = 0;

//Yttre loopen räknar första talet och körs till näst sista talet.
for (int i = 0; i < inputNumber.Length - 1; i++)
{
    if (inputNumber[i] != inputNumber[i + 1]) //kollar ifall andra talet är samma som det första i så fall fortsätter yttre loopen.
    {
        for (int j = i + 1; j < inputNumber.Length; j++) //Innre loopen som kollar talen efter det första
        {
            if (!char.IsDigit(inputNumber[j])) //Kollar om andra talet inte är ett tal i så fall avbryts inre loopen och första loopen går vidare till nästa tal och gör samma sak.
            {
                break;
            }

            if (inputNumber[i] == inputNumber[j]) //När det andra talet är samma som det första så tas första delsträngen ut
            {
                subString = inputNumber.Substring(i, j - i + 1);//Går igenom alla index och sparar undan dem som stämmer och lagrar dem hittade talen i en substräng.

                long result;
                long.TryParse(subString, out result);
                summaryOfAllSubStrings += result;

                beforeSubString = inputNumber.Substring(0, inputNumber.IndexOf(subString));
                endSubString = inputNumber.Substring(subString.Length + beforeSubString.Length, (inputNumber.Length) - (subString.Length + beforeSubString.Length));

                Console.Write(beforeSubString);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(subString);
                Console.ResetColor();
                Console.WriteLine(endSubString);
                break;

            }

        }

    
    }
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Totala summan: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(summaryOfAllSubStrings);
Console.ResetColor();

