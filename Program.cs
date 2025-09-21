namespace Assignment;

public class program
{
    public static void Main()
    {
        Player player = new Player("Kevin the Sneaky", 3, 10);
        IOpenableDoor openableDoor = new OpenableDoor();
        ILockedDoor lockedDoor = new LockedDoor();
        //IPaidDoor paidDoor = new PaidDoor();

        string userinput;

        bool canWalkThrough = false;
        while (true)
        {
            Console.WriteLine($"\n{player.Name} has encontered an openable door, what will he do?");
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
                    Console.WriteLine("\nThe door is open, you walk through");
                    break;
                }
                else
                {
                    Console.WriteLine("\nThe door is closed, you have to open it first");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid option selected, try again");
            }
        }

        canWalkThrough = false;
        bool isLocked = true;
        while (true)
        {
            Console.WriteLine($"\n{player.Name} has encontered an openable door, what will he do?");
            Console.WriteLine("1. Open the door");
            Console.WriteLine("2. Close the door");
            Console.WriteLine("3. Close the door");
            Console.WriteLine("4. Walk through the doorway");
            Console.Write("Choose an option> ");

            userinput = Console.ReadLine();
            if (userinput == "1")
            {
                if (isLocked)
                {
                    Console.WriteLine("The door is locked, you have to unlock it first");
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
                isLocked = lockedDoor.Unlock(player.Name, player.LockPicks);
            }
            else if (userinput == "4")
            {
                if (canWalkThrough && !isLocked)
                {
                    Console.WriteLine("\nThe door is open, you walk through");
                    break;
                }
                else
                {
                    Console.WriteLine("\nThe door is closed, you have to open it first");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid option selected, try again");
            }
        }
    }

    //void FirstDoor()
    //{

    //}

    //void SecondDoor()
    //{

    //}

    //void ThirdDoor()
    //{

    //}
}