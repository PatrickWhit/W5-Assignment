namespace Assignment
{
    internal class LockedDoor : IOpenableDoor, ILockedDoor//, IDoor
    {
        public bool IsOpen { get; set; }

        public bool Unlock(string name, int lockPicks)
        {
            Console.WriteLine($"\nThe door is now unlocked, and {name} now has {--lockPicks} lockpicks left");
            return false;
        }
        public bool Open()
        {
            if (IsOpen)
            {
                Console.WriteLine("\nThe door is already open");
                return true;
            }
            else
            {
                IsOpen = true;
                Console.WriteLine("\nThe door is now open");
                return true;
            }
        }
        public bool Close()
        {
            if (IsOpen)
            {
                IsOpen = false;
                Console.WriteLine("\nThe door is now closed");
                return false;
            }
            else
            {
                Console.WriteLine("\nThe door is already closed");
                return false;
            }
        }
    }
}