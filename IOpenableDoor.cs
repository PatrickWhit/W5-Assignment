namespace Assignment
{
    public interface IOpenableDoor
    {
        public bool IsOpen { get; set; }
        public bool Open();
        public bool Close();
    }
}