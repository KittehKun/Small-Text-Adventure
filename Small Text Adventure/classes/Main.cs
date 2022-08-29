// See https://aka.ms/new-console-template for more information
using Small_Text_Adventure;
using Small_Text_Adventure.classes;

MainMenu menu = new MainMenu();
switch(menu.MenuChoice)
{
    case 1:
        Player player = new Player(); //Creates player
        Console.WriteLine($"Welcome {player.Name}!");
        Console.WriteLine("\n\nPress any key to generate an adventure...");
        Console.ReadKey();
        Game newGame = new Game(player); //Creates New Adventure
        newGame.BeginAdventure();
        break;
    case 2:
        Console.Clear();
        Console.WriteLine("Exiting program...");
        Environment.Exit(0); //Ends Program
        break;
    default:
        break;
}