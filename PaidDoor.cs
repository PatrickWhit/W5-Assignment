namespace Assignment
{
    public class PaidDoor : IPaidDoor
    {
        public bool IsOpen { get; set; }
        public int goldPayRemain {  get; set; }

        public PaidDoor()
        {
            goldPayRemain = 5;
        }

        public bool pay(string name, int gold)
        {
            if (goldPayRemain > 0)
            {
                goldPayRemain--;
                Console.WriteLine($"\n{name} put a gold piece into the slot, he now has {gold} gold left.");
                return true;
            }
            else if (goldPayRemain == 0)
            {
                goldPayRemain--;
                Console.WriteLine($"\nThe door makes a ka-chunk sound, it is now unlocked.");
                Console.WriteLine($"{name} now has {gold} gold left.");
                return false;
            }
            else
            {
                Console.WriteLine($"\nThe fee has already been payed.");
                return false;
            }
        }
        public bool Open()
        {
            if (IsOpen)
            {
                Console.WriteLine("\nThe door is already open.");
                return true;
            }
            else
            {
                IsOpen = true;
                Console.WriteLine("\nThe door is now open.");
                return true;
            }
        }
        public bool Close()
        {
            if (IsOpen)
            {
                IsOpen = false;
                Console.WriteLine("\nThe door is now closed.");
                return false;
            }
            else
            {
                Console.WriteLine("\nThe door is already closed.");
                return false;
            }
        }
    }
}