namespace Person
{
    [Serializable]
    public class Person
    {
        //public Guid Id { get; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = string.Empty;
            Age = 0;
        }

        //[Serializable]
        //public class Professors
        //    {
        //        public List <Person>? Profs { get; set; }

        //        public Professors()
        //        {

        //        }
        //    }
        //public class PersonManager : Person
        //{
        //    public List<Person> People { get; set; }

        //    public PersonManager()
        //    {
        //        People = new List<Person>();
        //    }
        //}
    }
}