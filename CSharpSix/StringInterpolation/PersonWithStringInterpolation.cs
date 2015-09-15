namespace CSharpSix.StringInterpolation
{
    public class PersonWithStringInterpolation
    {
        private readonly string firstName;
        private readonly string lastName;

        public PersonWithStringInterpolation(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string Name => $"{this.firstName} {this.lastName}";
        //// public string Name
        //// {
        ////     get
        ////     {
        ////         return string.Format("{0} {1}", this.firstName, this.lastName);
        ////     }
        //// }
    }
}
