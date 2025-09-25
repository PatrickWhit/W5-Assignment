namespace Assignment
{
    public interface IPaidDoor : IOpenableDoor
    {
        public bool IsOpen { get; set; }
        public int goldPayRemain { get; set; }
        public bool pay(string name, int gold);
    }
}