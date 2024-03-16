namespace HW2turnip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>
            {
                new Character("Did"),
                new Character("Babka"),
                new Character("Vnuchka"),
                new Character("Zhuchka")
            };

            IHerb turnip = new Turnip();
            turnip.Grow();

            bool isSuccess = false;

            foreach (Character character in characters) 
            {
                Console.WriteLine($"{character.Name} try to pull");
                isSuccess = character.Pull(turnip);

                if (isSuccess ) 
                {
                    Console.WriteLine($"{character.Name} successfully pulled");
                    break;
                }
                else
                {
                    Console.WriteLine($"{character.Name} can`t pulled need help");
                }
            }

            if ( !isSuccess )
            {
                Console.WriteLine($"Nobody can`t pulled");
            }
        }
    }
}
