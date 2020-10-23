namespace StoreUI.Menus
{
    /// <summary>
    /// The welcome menu for people who come in and stuff
    /// </summary>
    public class MainMenu : IMenu
    {
        public void Start() {
            string userInput;
            do{
                System.Console.WriteLine("Welcome to CF Books");

                //Menu Options
                System.Console.WriteLine("[0] Menu option \n[1] Another Menu Option");
                userInput = System.Console.ReadLine();
                switch (userInput)
                {
                    case "0" :
                        // Hero newHero = GetHeroDetails();
                        // heroBL.AddHero(newHero);
                        // System.Console.WriteLine($"Hero {newHero.name} was created with a superpower of {Hero.superPowers.Pop()}");
                        break;
                    case "1":
                        // List<Hero> allHeroes = heroBL.GetAllHeroes();
                        // foreach(var hero in allHeroes){
                            // System.Console.WriteLine($"Hero {hero.name}");
                        // }
                        break;
                }

            } while(!userInput.Equals("0") || !userInput.Equals("1"));
        }
    }
}