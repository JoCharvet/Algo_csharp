// See https://aka.ms/new-console-template for more information
double nb_user = -800;
double result_m = 0;
string rep_user = "";
string unite_user = "";
string res_end = "";
bool stop=false;

// repeat until the user tap quit
while (!stop)
{


    // input control of nb_user if beetween -459.67 and 5 000 000 and check if a unit of measure have been choosed1
    while ((nb_user < -459.67 || nb_user > 5000000) && (unite_user!="c" || unite_user!="f"))
    {
        Console.WriteLine("Veuillez saisir un nombre entre -459.67 et 5 000 000 (preciser si C ou F à la fin)");
        try
        {
            rep_user = Console.ReadLine().Replace(".", ",");
            if (rep_user == "quit")
            {
                stop = true;
                rep_user = "0C";
            }

            unite_user = rep_user[^1..].ToLower();

            nb_user = double.Parse(rep_user.Substring(0, rep_user.Length - 1));
        }
        catch (Exception e)
        {
            Console.WriteLine("Nombre saisie incorrect");
            throw ;
        }
    }

    // in function of the unit of measure convert C in F or F in C
    if (unite_user == "c")
    {
        result_m = Math.Round((nb_user * 9 / 5) + 32, 2);
        res_end = nb_user + " °C équivaut à " + result_m + " °F";
    }
    else
    {
        result_m = Math.Round(((nb_user - 32) * 5 / 9), 2);
        res_end = nb_user + " °F équivaut à " + result_m + " °C";
    }

    // display the final result
    Console.WriteLine(res_end);
    Console.ReadKey();
    nb_user = -800;
}
Console.WriteLine("Fin de programme");