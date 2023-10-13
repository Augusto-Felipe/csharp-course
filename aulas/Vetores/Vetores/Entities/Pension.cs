namespace Vetores.Entities
{
    internal class Pension
    {
        public Room[] Rooms { get; private set; }

        public Pension()
        { 
            Rooms = new Room[10];
        }

        public void Rent(string name, string email, int roomNumber)
        {
            Rooms[roomNumber] = new Room(name, email, roomNumber);
        }
    }
}
