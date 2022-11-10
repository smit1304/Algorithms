class Pizza
{
    public string Size;
    public List<String> ToppingAdded = new List<String>();
}

class Order
{
    public string Size;
    public List<String> ToppingAdded = new List<String>();
    public static List<String> Topings = new List<string>(){
            "ONION","TOMATO","GREEN PAPER","MASHROOM","OLIVE","SPINACH","BROCCOLY",
            "PINEAPPLE","HOT PAPER","PEPRONI","HAM","BECON","BROWN BEAF","CHIKEN",
            "SAUSAGE"
    };
    public static void Main(string[] args)
    {
        Order order = new Order();
        Console.Write("Do you want to order pizza ? ");
        string answer = Console.ReadLine();


        if (answer == "NO" || answer == "Q")
        {
            return;
        }

        //select size of pizza
        do
        {
            Console.Write("size : ");
            order.Size = Console.ReadLine();

        } while (order.Size != "S" &&
                 order.Size != "M" &&
                 order.Size != "L" &&
                 order.Size != "XL");


        // Topping Zone

        do
        {
        here:
            Console.Write("Type in one our topping to add into your pizza to see the list of topping enter 'LIST' when you are done adding topping enter 'X' : ");
            string response = Console.ReadLine();

            if (response == "LIST")
            {
                Console.WriteLine("These are the Topings : ");
                foreach (string s in Topings)
                {
                    Console.Write(s + " ");
                }
                continue;
            }
            foreach (string s in Topings)
            {
                if (s.Equals(response))
                {
                    Console.WriteLine(s + " Topping Added to pizza");
                    goto here;
                }
            }
            if (response == "X")
            {
                break;
            }

            Console.WriteLine("Input invalid !");

            goto here;

        } while (true);
        //Console.WriteLine(order.Size);



    }
}

class PizzaResipt
{

}