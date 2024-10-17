
using System.Reflection.PortableExecutable;

Dictionary<string, List<string>> animes = new Dictionary<string, List<string>>();
animes["Attack on titan"] = new List<string> { "Eren","Mikasa","Armin" };
animes["One Piece"] = new List<string> { "Luffy", "Zoro", "Sanji" };



void displayMenu()
{
    Console.Clear();
Console.WriteLine(@"
░█████╗░███╗░░██╗██╗███╗░░░███╗███████╗░░░░░░██╗░░░░░██╗██████╗░██████╗░░█████╗░██████╗░██╗░░░██╗
██╔══██╗████╗░██║██║████╗░████║██╔════╝░░░░░░██║░░░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗░██╔╝
███████║██╔██╗██║██║██╔████╔██║█████╗░░█████╗██║░░░░░██║██████╦╝██████╔╝███████║██████╔╝░╚████╔╝░
██╔══██║██║╚████║██║██║╚██╔╝██║██╔══╝░░╚════╝██║░░░░░██║██╔══██╗██╔══██╗██╔══██║██╔══██╗░░╚██╔╝░░
██║░░██║██║░╚███║██║██║░╚═╝░██║███████╗░░░░░░███████╗██║██████╦╝██║░░██║██║░░██║██║░░██║░░░██║░░░
╚═╝░░╚═╝╚═╝░░╚══╝╚═╝╚═╝░░░░░╚═╝╚══════╝░░░░░░╚══════╝╚═╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░");
Console.WriteLine("\nWhere you can find all information about your favorite anime characters!");

Console.WriteLine("1 - Animes List");
Console.WriteLine("2 - Characters List");
Console.WriteLine("3 - Register an Anime");
Console.WriteLine("4 - Register a Character\n");


    


    int option = int.Parse(Console.ReadLine());


switch (option)
{
    case 1:
        Console.Clear();
        displayAllAnimes();
        break;
    case 2:
            displayAllCharaters();
        break;
    case 3:
        Console.Clear();
        registerAnime();
        break;
    case 4:
        Console.Clear();
        Console.WriteLine("Character Registration");
        break;


}
    
}

void displayAllAnimes()
{
    
    
    foreach(string anime in animes.Keys)
    {
        Console.WriteLine(anime);
    }

    Console.ReadLine();
    displayMenu();
}

void displayAllCharaters()
{
    Console.Clear();
    Console.WriteLine("Which anime do you want to see the characters?");
    string searchedAnime = Console.ReadLine();
    if (animes.ContainsKey(searchedAnime))
    {
        Console.Clear();
        foreach(var character in animes[searchedAnime])
        {
            Console.WriteLine(character);
        }
        Console.ReadLine();
        displayMenu();
    }
    else 
    {
        Console.WriteLine("This anime do not exist!");
        Console.ReadLine();
        displayMenu();
    }
}

void registerAnime()
{
    Console.WriteLine("Which anime do you want to register?");
    string newAnime = Console.ReadLine(); 
    
    Console.WriteLine("Anime successfully registered!");
    displayMenu();

}


displayMenu();