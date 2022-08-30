using Small_Text_Adventure.interfaces;

namespace Small_Text_Adventure.classes
{
    public class Player : IPlayerTemplate
    {
        //Interface
        public string Name { get; private set; }
        //Constructor
        public Player()
        {
            Console.Clear();
            this.Name = SetPlayerName();            
        }

        //Methods

        /// <summary>
        /// Sets the players name based on input.
        /// </summary>
        /// <returns>Name as a string.</returns>
        private string SetPlayerName()
        {
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();
            if(name != null)
            {
                Console.Clear();
                return name;
            } else
            {
                Console.WriteLine("Name cannot be null.");
                return SetPlayerName();
            }
        }
    }
}