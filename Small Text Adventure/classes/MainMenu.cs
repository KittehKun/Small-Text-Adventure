using System.Collections;

namespace Small_Text_Adventure
{
    public class MainMenu
    {
        //Fields
        private ArrayList menuList = new ArrayList();
        private int menuChoice;

        //Constructor
        public MainMenu()
        {
            InitializeMenu();
            foreach(string menuOption in menuList)
            {
                Console.WriteLine(menuOption);
            }
            this.menuChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }


        //Properties
        public int MenuChoice 
        {
            get {return this.menuChoice;}
        }

        //Methods
        private void InitializeMenu()
        {
            this.menuList.Add("1. Begin New Adventure");
            this.menuList.Add("2. Quit");
        }
        
    }
}