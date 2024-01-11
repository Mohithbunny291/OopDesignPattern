namespace OopsDesignPattern
{
    internal class Teacher : IEntityWithName
    {
        public string Name { get; set; }
        public string Subject { get; set; }

        public Teacher(string name, string subject)
        {
            Name = name;
            Subject = subject;
        }
    }
}
