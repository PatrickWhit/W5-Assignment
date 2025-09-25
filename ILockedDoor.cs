namespace Assignment
{
    public interface ILockedDoor : IOpenableDoor
    {
        public bool IsUnlocked { get; set; }
        public bool Unlock(string name, int lockPicks);
    }
}