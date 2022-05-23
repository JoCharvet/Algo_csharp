int[] tab = new int[20];
List<int> list_young = new List<int>();
List<int> list_not_really_young = new List<int>();
List<int> list_twenty= new List<int>();
string temp="";
Random rnd = new Random();

// insert random value in the array
for (int i = 0; i < tab.Length; i++)
{
    tab[i] = rnd.Next(0,99);
}
// check for every number in tab if the value is lower than the target value
foreach (int i in tab)
{
    if (i<20)
    {
      list_young.Add(i);
    }
    else if (i==20)
    {
       list_twenty.Add(i);
    }
    else
    {
        list_not_really_young.Add(i);
    }
}
// display the result
Console.WriteLine("nb de jeunes = "+list_young.Count+" nb de moins jeunes = "+list_not_really_young.Count);
if (list_young.Count == tab.Length)
{
    Console.WriteLine("TOUTES LES PERSONNES ONT MOINS DE 20 ANS");
}
else if( list_not_really_young.Count == tab.Length)
{
    Console.WriteLine("TOUTES LES PERSONNES ONT PLUS DE 20 ANS");
}
else
{
    Console.WriteLine("Moins de 20 ans");
    foreach (var item in list_young)
    {
        temp += " " + item + " ";

    }
    Console.WriteLine(temp);
    temp = "";
    Console.WriteLine("plus de 20 ans");
    foreach (var item in list_not_really_young)
    {
        
        temp += " " + item + " ";
    }
    Console.WriteLine(temp);
    temp = "";
    Console.WriteLine("de 20 ans");
    foreach (var item in list_twenty)
    {
        temp += " " + item + " ";
    }
    Console.WriteLine(temp);
}


