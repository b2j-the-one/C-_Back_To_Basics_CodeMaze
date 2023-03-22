/*#region Program that accepts the name and surname, separated by spaces, as input, then prints the name on one line and the surname on another line.
Console.WriteLine("Entrez votre nom complet, séparé par des espaces.");
string fullName = Console.ReadLine();

int blankPosition = fullName.IndexOf(' ');
string name = fullName.Substring(0, blankPosition);
string lastName = fullName.Substring(blankPosition + 1);

Console.WriteLine(name);
Console.WriteLine(lastName); 

Console.ReadKey();
#endregion*/

/*#region Program that accepts as input a sentence and deletes the first and last words of that sentence.
Console.Write("Entrez votre phrase : ");
string word = Console.ReadLine();

int blankPosition = word.IndexOf(' ');
int firstWordWithSpaceLength = word.Substring(0, blankPosition).Length;
string removeFirstWord = word.Remove(0, firstWordWithSpaceLength + 1);
int lastBlankPosition = removeFirstWord.LastIndexOf(' ');
string removeLastWord = removeFirstWord.Remove(lastBlankPosition);

Console.WriteLine(removeLastWord);


Console.Write("Entrez votre phrase : ");

string sentence = Console.ReadLine();
int firstBlankPosition = sentence.IndexOf(' ');

string withoutFirstWord = sentence.Remove(0, firstBlankPosition + 1);
int lastBlankPosition = withoutFirstWord.LastIndexOf(' ');
string withoutFirstAndLast = withoutFirstWord.Remove(lastBlankPosition);
Console.WriteLine(withoutFirstAndLast);
Console.ReadKey();
#endregion*/


#region Array
/*int[] numbers = new int[5] { 4, 5, 7, 8, 3 };

for (int i = 0; i < numbers.Length; i++)
{
Console.WriteLine(numbers[i]);
}

foreach (int i in numbers)
{
Console.WriteLine(i);
}*/

/*void PopulateArray(int[] numbers)
{
    Random r = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = r.Next(1, 101);
        Console.WriteLine($"Le {i + 1} élément est : {numbers[i]}");
    }
}

void CalculateSum(int[] numbers)
{
    int sum = 0;
    foreach (int i in numbers)
    {
        sum += i;
    }

    Console.WriteLine($"La somme de tous les éléments est : {sum}");
}

Console.WriteLine("Entrez la capacité du tableau: ");
int capacity = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[capacity];

PopulateArray(numbers);
Console.WriteLine();
CalculateSum(numbers);

Console.ReadKey();*/

/*void PrintMin(params int[] numbers)
{
    int min = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (min > numbers[i])
        {
            min = numbers[i];
        }
    }
    
    // We can use the Min() method.
    int minNumber = numbers.Min();

    Console.WriteLine(min);
}

PrintMin(49, 58, 12, 98, 47, 13);
Console.ReadKey();*/

// Tableau Multidimensions
int[,] numbersMultiDim = new int[3, 2] { { 1, 5 }, { 3, 8 }, { 6, 1 } };

/*for (int i = 0; i < numbersMultiDim.GetLength(0); i++)
{
    for (int j = 0; j < numbersMultiDim.GetLength(1); j++)
    {
        Console.WriteLine(numbersMultiDim[i, j]);
    }
}*/

int number = numbersMultiDim[2, 1];
Console.WriteLine(number);
#endregion

