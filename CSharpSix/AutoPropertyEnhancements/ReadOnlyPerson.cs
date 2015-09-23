namespace AutoPropertyEnhancements
{
    public class ReadOnlyPerson
    {
        public ReadOnlyPerson()
        {
            this.FirstName = "test";
        }

        public string FirstName { get; } = "Nikolay";

        public string LastName { get; } = "Kostov";
    }
}
