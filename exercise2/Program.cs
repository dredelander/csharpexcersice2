using System.Text.Json;

namespace exercise2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type 'exit' to quit");

        string userInput = Console.ReadLine();

        while(userInput.ToLower() != "exit")
        {
            //Console.WriteLine("Press 1 to add a product");
            //Console.WriteLine("Type 'exit' to quit");
            //userInput = Console.ReadLine();
            if(userInput == "1")

            {
                Console.WriteLine("Enter Product Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Product Price");
                decimal price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Product Quantity");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Description");
                string Description = Console.ReadLine();
                Console.WriteLine("Is this Kitten Food? Y/N");
                bool kittenFood = Console.ReadLine().ToUpper() == "Y";
                Console.WriteLine("What is the weight in pounds?");
                double weight = Convert.ToDouble(Console.ReadLine());
                

                CatFood cattyMuch = new CatFood
                {
                    Name = name,
                    Price = price,
                    Quantity = quantity,
                    Description = Description,
                    KittenFood = kittenFood,
                    WeightPounds = weight,

                };

                Console.WriteLine(JsonSerializer.Serialize(cattyMuch));
                Console.WriteLine();

            }

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");

            userInput = Console.ReadLine();

        }
    }
}

