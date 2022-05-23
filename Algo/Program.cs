// See https://aka.ms/new-console-template for more information
string str_util="";
string result = " est un palindrome";
int i=0;
int n=0;

//input control , if the last char of the string are not a dot or if the string are not long of two char
while(str_util.Length <2 || str_util.Substring(str_util.Length-1) != ".")
{
    Console.WriteLine("Veuillez saisir une phrase terminant par un .");
    str_util = Console.ReadLine();
}
str_util.ToUpper();
n = str_util.Length - 2;


// compare the first char of the string and the last , if they have the same value we continue until the middle of the word, if not its not a palindrome
while(i!=n || i > n)
{
    if (str_util[i]!= str_util[n])
    {
        result=" n'est pas un palindrome";
        n = 2;
    }
    i++;
    n--;
}
// display the final result
Console.WriteLine(str_util + result);
Console.ReadKey();
