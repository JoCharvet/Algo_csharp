// See https://aka.ms/new-console-template for more information
double nb_user = 0;
double result_m = 0;
string rep_user = "";
string unite_user = "";
string res_end = "";


// input control of nb_user if beetween 0.01 and 1 000 000 and check if a unit of measure have been choosed else select km by default
while (nb_user < 0.01 || nb_user> 1000000)
{
    Console.WriteLine("Veuillez saisir un nombre entre 0.01 et 1 000 000 (preciser si mi ou km à la fin)");
    try
    {
        rep_user = Console.ReadLine();
        unite_user = rep_user[^2..].ToLower();
        if(unite_user!="mi" && unite_user != "km")
        {
            unite_user = "km";
            rep_user = rep_user + " " + unite_user; 
        }
        nb_user = double.Parse(rep_user.Substring(0,rep_user.Length -2));
    }
    catch (Exception e)
    {
        Console.WriteLine("Nombre saisie incorrect");
        throw;
    }
}

// in function of the unit of measure convert miles in km or km in miles
if(unite_user == "km")
{
    result_m =Math.Round(nb_user/1.609 ,2);
    res_end = nb_user + " represente " + result_m + " miles";
}
else
{
    result_m = Math.Round(nb_user * 1.609, 2);
    res_end = nb_user + " represente " + result_m + " km";
}

// display the final result
Console.WriteLine(res_end);
Console.ReadKey ();