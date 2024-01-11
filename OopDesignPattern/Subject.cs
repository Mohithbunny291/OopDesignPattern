namespace OopsDesignPattern
{
    internal class Subject : IEntityWithName
    {
        public string Name { get; set; }
        public string SubCode { get; set; }

        public Subject(string name, string code)
        {
            Name = name;
            SubCode = code;
        }
    }
}
