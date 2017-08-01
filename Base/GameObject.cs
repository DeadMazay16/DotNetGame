namespace DotNetGame
{
    public class GameObject
    {
        private static int _id = 0;
        public int Id { get; }
        public string Name { get; }

        public GameObject(string name)
        {
            Id = _id;
            this.Name = name;
            _id++;
        }
    }
}