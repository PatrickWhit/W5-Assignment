namespace Assignment
{
    public class Player
    {
        public string Name { get; set; }
        public int LockPicks { get; set; }
        public int Gold { get; set; }

        public Player(string name, int picks, int gold)
        {
            Name = name;
            LockPicks = picks;
            Gold = gold;
        }
    }
}