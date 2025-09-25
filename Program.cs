namespace Assignment;

public class program
{
    public static void Main()
    {
        Player player = new Player("Kevin the Sneaky", 3, 10);
        IOpenableDoor openableDoor = new OpenableDoor();
        ILockedDoor lockedDoor = new LockedDoor();
        IPaidDoor paidDoor = new PaidDoor();

        Console.WriteLine($"{player.Name} has snuk into a mansion to plunder it's valuables.");
        Console.WriteLine($"He has brought {player.LockPicks} lock picks and {player.Gold} gold with him for the journey.");

        string userinput;
        bool canWalkThrough = false;
        while (true) // First door the player has to walk through
        {
            Console.WriteLine($"\nWhile in the mansion {player.Name} has encontered an openable door, what will he do?");
            Console.WriteLine("1. Open the door");
            Console.WriteLine("2. Close the door");
            Console.WriteLine("3. Walk through the doorway");
            Console.Write("Choose an option> ");

            userinput = Console.ReadLine();
            if (userinput == "1")
            {
                canWalkThrough = openableDoor.Open();
            }
            else if (userinput == "2")
            {
                canWalkThrough = openableDoor.Close();
            }
            else if (userinput == "3")
            {
                if (canWalkThrough)
                {
                    Console.WriteLine("\nThe door is open, you walk through.");
                    break;
                }
                else
                {
                    Console.WriteLine("\nThe door is closed, you have to open it first.");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid option selected, try again.");
            }
        }

        canWalkThrough = false;
        bool isLocked = true;
        while (true) // Second door the player has to walk through
        {
            Console.WriteLine($"\nAfter walking through the first door, {player.Name} has encontered a locked door, what will he do?");
            Console.WriteLine("1. Open the door");
            Console.WriteLine("2. Close the door");
            Console.WriteLine("3. Walk through the doorway");
            Console.WriteLine("4. Unlock the door");
            Console.Write("Choose an option> ");

            userinput = Console.ReadLine();
            if (userinput == "1")
            {
                if (isLocked)
                {
                    Console.WriteLine("\nThe door is locked, you have to unlock it first.");
                }
                else
                {
                    canWalkThrough = lockedDoor.Open();
                } 
            }
            else if (userinput == "2")
            {
                canWalkThrough = lockedDoor.Close();
            }
            else if (userinput == "3")
            {
                if (canWalkThrough && !isLocked)
                {
                    Console.WriteLine("\nThe door is open, you walk through.");
                    break;
                }
                else
                {
                    Console.WriteLine("\nThe door is closed, you have to open it first.");
                }
            }
            else if (userinput == "4")
            {
                isLocked = lockedDoor.Unlock(player.Name, player.LockPicks);
            }
            else
            {
                Console.WriteLine("\nInvalid option selected, try again.");
            }
        }

        canWalkThrough = false;
        isLocked = true;
        while (true) // Third door the player has to walk through
        {
            Console.WriteLine($"\n{player.Name} has encontered a locked door.");
            Console.WriteLine("While the door has no visible lock, it does possess a slot that would seem to fit a gold piece.");
            Console.WriteLine($"What will {player.Name} do?");
            Console.WriteLine("1. Open the door");
            Console.WriteLine("2. Close the door");
            Console.WriteLine("3. Walk through the doorway");
            Console.WriteLine("4. Put a gold piece in the slot");
            Console.Write("Choose an option> ");

            userinput = Console.ReadLine();
            if (userinput == "1")
            {
                if (isLocked)
                {
                    Console.WriteLine("\nThe door is locked, you have to unlock it first.");
                }
                else
                {
                    canWalkThrough = paidDoor.Open();
                }
            }
            else if (userinput == "2")
            {
                canWalkThrough = paidDoor.Close();
            }
            else if (userinput == "3")
            {
                if (canWalkThrough && !isLocked)
                {
                    Console.WriteLine("\nThe door is open, you walk through.");
                    break;
                }
                else
                {
                    Console.WriteLine("\nThe door is closed, you have to open it first.");
                }
            }
            else if (userinput == "4")
            {
                player.Gold--;
                isLocked = paidDoor.pay(player.Name, player.Gold);
            }
            else
            {
                Console.WriteLine("\nInvalid option selected, try again.");
            }
        }

        Console.WriteLine($"\nAfter making his way past the 3 doors, {player.Name} finds himself in a room filled with untold riches.");
        Console.WriteLine("He brings out his sack and stuffs it full with as many valuables as it can hold.");
        Console.WriteLine($"When the sack is close to bursting, {player.Name} ties it up, lofts it over his shoulder, and makes his grand escape from the mansion.");
    }
}