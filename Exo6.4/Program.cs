using System.Text.RegularExpressions;

string sentence = "Lorem ipsum 8dolor sit amet, aconsectetur2 adipiscing elit. Nam 6pulvinar non eros sit amet sodales sed.";
string tmp = "";
int total_vowels=0;
int total_consonant=0;
int total_number = 0;
List<int> ints= new List<int>(); 
double ave_num=0;
Regex myreg_num = new Regex(@"\d");
Regex myreg_alp = new Regex(@"[a-z]");
Regex myreg_vowel = new Regex(@"[aeiouy]");

// convert sentence to lower case
sentence = sentence.ToLower();

// check each character in the sentence and increment the value of the adequat counter
foreach (char item in sentence)
{
    tmp +=item;
    if (myreg_alp.IsMatch(tmp))
    {
        if (myreg_vowel.IsMatch(tmp))
        {
            total_vowels++;
        }
        else
        {
            total_consonant++;
        }
    }
    else if (myreg_num.IsMatch(tmp))
    {
        ints.Add(int.Parse(tmp));
        total_number++;
    }
    tmp = "";
}

tmp = "La phrase contient " + total_vowels + " voyelles, " + total_consonant + " consonnes." ;
// do the average of all number in ints and add the display to tmp
if (ints.Count > 0)
{
    ave_num = ints.Average();
    tmp += "/n " + total_number + " nombre, la moyenne des nombre est de " + Math.Round(ave_num,2);
}

// display the result
Console.WriteLine(sentence);
Console.WriteLine(tmp);



