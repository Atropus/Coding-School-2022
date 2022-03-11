namespace Person
{
    [Serializable]
    public class Professor : Person
    {
        public string Rank { get; set; }

        //TODO Courses

        public Professor(string _name, int _age, string _rank)
        {
            Rank = _rank;
        }
    }
}