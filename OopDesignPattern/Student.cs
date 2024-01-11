namespace OopsDesignPattern
{
    internal class Student : IEntityWithName
    {
        public string Name { get; set; }
        public int Class { get; set; }
        public char Section { get; set; }

        public Student(string name, int cls, char section)
        {
            Name = name;
            Class = cls;
            Section = section;
        }
    }
}
