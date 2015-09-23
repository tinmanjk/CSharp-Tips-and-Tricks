namespace NameofExpressions
{
    using System;

    public class PersonWithValidation
    {
        private readonly string firstName;
        private readonly string lastName;

        public PersonWithValidation(string firstName, string lastName)
        {
            if (firstName == null)
            {
                throw new ArgumentNullException(nameof(firstName));
            }

            if (lastName == null)
            {
                throw new ArgumentNullException(nameof(lastName));
            }

            this.firstName = firstName;
            this.lastName = lastName;
        }

        //  public string Name => $"{this.firstName} {this.lastName}";
        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.firstName, this.lastName);
            }
        }
    }
}
