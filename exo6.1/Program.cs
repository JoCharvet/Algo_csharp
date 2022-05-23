// See https://aka.ms/new-console-template for more information
double prix = 0;
string ingredient = "";
string rep_user="";
string[] tmp;

bool canConvert = false;

SortedDictionary<string, double> dict = new SortedDictionary<string, double>();

dict.Add("carotte", 2.99);
dict.Add("ail", 3.24);
dict.Add("oignon", 2.48);
dict.Add("patate", 0.85);

// End i the user tap "go"
while (rep_user != "go")
{
    // the user add some ingredient/price to the dictionnary if the input format are correct the input will added
    do
    {
        Console.WriteLine("Veuillez saisir un ingredient et son prix/kg séparé d'un espace ex: carottes 2,99");
        rep_user = Console.ReadLine().Replace(".",",");
        if (rep_user=="go")
        {
            canConvert=true;
        }
        else
        {
            tmp = rep_user.Split(" ");
            
            canConvert = double.TryParse(tmp[1], out prix);
            ingredient = tmp[0];
            if (canConvert) 
            {
                dict.Add(ingredient, prix);
            }
            
        }
        
    } while (!canConvert);
 
}

// for retrieve the cheapest ingredient 
 var dict2 = dict.OrderBy(key => key.Value);
//dict = (SortedDictionary<string, double>)(from entry in dict orderby entry.Value ascending select entry);


// display the dictionnary
foreach (var item in dict)
{
    Console.WriteLine("1 kilogramme de " + item.Key + " coute " + item.Value + " euros.");
}
// display the cheapest ingredient
Console.WriteLine("Légume le moins cher au kilo : "+ dict.First().Key);

