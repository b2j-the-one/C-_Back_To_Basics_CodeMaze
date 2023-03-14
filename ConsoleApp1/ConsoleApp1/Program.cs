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

#region Program that accepts as input a sentence and deletes the first and last words of that sentence.
/*Console.Write("Entrez votre phrase : ");
string word = Console.ReadLine();

int blankPosition = word.IndexOf(' ');
int firstWordWithSpaceLength = word.Substring(0, blankPosition).Length;
string removeFirstWord = word.Remove(0, firstWordWithSpaceLength + 1);
int lastBlankPosition = removeFirstWord.LastIndexOf(' ');
string removeLastWord = removeFirstWord.Remove(lastBlankPosition);

Console.WriteLine(removeLastWord);*/

Console.Write("Entrez votre phrase : ");

string sentence = Console.ReadLine();
int firstBlankPosition = sentence.IndexOf(' ');

string withoutFirstWord = sentence.Remove(0, firstBlankPosition + 1);
int lastBlankPosition = withoutFirstWord.LastIndexOf(' ');
string withoutFirstAndLast = withoutFirstWord.Remove(lastBlankPosition);
Console.WriteLine(withoutFirstAndLast);
Console.ReadKey();
#endregion
