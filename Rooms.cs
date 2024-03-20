namespace InventorySystem
{
    public class Room
    {
        public string ShortDescription { get; private set; }
        public string Continent { get; private set; }
        public Dictionary<string, Room> Exits { get; private set; } = new();
        public string? Item;

        public Room(string shortDesc, string continent)
        {
            ShortDescription = shortDesc;
            Continent = continent;
        }

        public void SetExits(Room? mainRoom,Room? europe, Room? africa, Room? america, Room? asia, Room? oceania)
        {
            SetExit("home", mainRoom);
            SetExit("europe", europe);
            SetExit("africa", africa);
            SetExit("america", america);
            SetExit("asia", asia);
            SetExit("oceania", oceania);
        
        }

        public void SetExit(string direction, Room? neighbor)
        {
            if(neighbor != null)
                Exits[direction] = neighbor;
        }
    }
}