
int comp_score=0;
int comp_turn=0;
int player_score=0;
int player_turn=3;
int score_limit=0;
string result = "";
bool canConvert=false;
Random rnd= new Random();

Console.WriteLine("JEU DU 0-1-2");

// until the score_limit have been set
do
{
    Console.WriteLine("Le jeu doit s'arreter après combien de manche gagné ?");
    canConvert = int.TryParse(Console.ReadLine(), out score_limit);
    if (canConvert)
    {
        Console.WriteLine("Limite de jeu enregistré à " + score_limit);
    }
    else
    {
        Console.WriteLine("Valeur saisie non valide");
    }
} while (score_limit <= 0);


// until the score is equal to limit or if the player decide to leave
while ((comp_score < score_limit && player_score < score_limit) || player_turn<0)
{
   
    //until the player choice is valid
    do
    {
        Console.WriteLine("Veuillez saisir un nombre 0, ,1 ou 2 (ou une valeur négative pour quitter).");
        canConvert = int.TryParse(Console.ReadLine(), out player_turn);
        if (canConvert && player_turn<=2)
        {
            Console.WriteLine("choix enregistré "+player_turn+" !");
        }
        else
        {
            Console.WriteLine("Valeur saisie non valide");
        }
    } while (player_turn>2);

    
    comp_turn = ComputerTurn(rnd);
    Turn(comp_turn,player_turn,ref comp_score, ref player_score);

}

// compare score for display the result of the game
if (comp_score>player_score)
{
    result = "L'ordinateur gagne avec " + comp_score +" contre joueur avec "+player_score;
}
else if (comp_score<player_score)
{
    result = "Le Joueur gagne avec " + player_score + " contre l'ordinateur avec " + comp_score;
}
else
{
    result = " Ex aequo !";
}
//display the result after a game
Console.WriteLine(result);


// simulated the computer choice
 static int ComputerTurn(Random _rnd)
{
    int comp_turn = _rnd.Next(0,3);
    Console.WriteLine("L'ordinateur choisie "+ comp_turn);
    return comp_turn;
}
// compare user and computer choice for know who win
 static void Turn ( int _comp_turn, int _player_turn,ref int _comp_score, ref int _player_score)
{
    if(_comp_turn==_player_turn)
    {
        Console.WriteLine("Egalité !");
    }
    else if (_comp_turn - 1 == _player_turn || _player_turn - 2 == _comp_turn)
    {
        Console.WriteLine("Le joueur marque !");
        _player_score++;
    }
    else
    {
        Console.WriteLine("L'ordinateur marque !");
        _comp_score++;
    }
}


