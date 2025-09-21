namespace Assignment;

public class program
{
    public static void Main()
    {
        Player player = new Player("Kevin the Sneaky", 3, 10);
        IDoor openableDoor = new OpenableDoor();
        IDoor lockedDoor = new LockedDoor();
        IDoor paidDoor = new PaidDoor();

        string userinput;

        bool canWalkThrough = true;
        while (canWalkThrough)
        {
            Console.WriteLine($"\n{player.Name} has encontered an openable door, what will he do?");
            Console.WriteLine("1. Open the door");
            Console.WriteLine("2. Close the door");
            Console.WriteLine("3. Walk through the doorway");
            Console.Write("Choose an option> ");

            userinput = Console.ReadLine();
            if (userinput == "1")
            {
                openableDoor.Open();
            }
            else if (userinput == "2")
            {
                openableDoor.Close();
            }
            else if (userinput == "3")
            {

            }
            else
            {
                Console.WriteLine("Invalid option selected, try again");
            }
        }
    }
}