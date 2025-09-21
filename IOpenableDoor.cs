namespace Assignment
{
    internal interface IOpenableDoor
    {
        public bool IsOpen { get; set; }
        public void Open();
        public void Close();
    }
}