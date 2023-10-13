namespace Vetores.Entities
{
    internal class Room
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Number { get; private set; }

        public Room(string name, string email, int number)
        {
            Name = name;
            Email = email;
            Number = number;
        }
    }
}