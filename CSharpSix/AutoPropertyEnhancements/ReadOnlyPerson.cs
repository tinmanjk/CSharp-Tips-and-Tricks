namespace AutoPropertyEnhancements
{
    public class ReadOnlyPerson
    {
        public string FirstName { get; } = "Nikolay";

        public string LastName { get; } = "Kostov";

        public ReadOnlyPerson()
        {
            this.FirstName = "test";
        }
    }
}
