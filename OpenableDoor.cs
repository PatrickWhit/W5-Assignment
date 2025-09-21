namespace Assignment
{
    internal class OpenableDoor : IOpenableDoor//, IDoor
    {
        public bool IsOpen { get; set; }
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