namespace ExpressionBodiedFunctionMembers
{
    using System.Collections.Generic;
    using System.Linq;

    public class PersonWithChildren
    {
        public PersonWithChildren(string firstName, string lastName)
        {
            this.Children = new List<PersonWithChildren>();
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public List<PersonWithChildren> Children { get; set; }

        private string FirstName { get; set; }

        private string LastName { get; set; }

        public string Name => this.FirstName + " " + this.LastName;

        public PersonWithChildren this[string name] =>
            this.Children.FirstOrDefault(
                x => x.Name.ToLower().Contains(name.ToLower()));
    }
}
