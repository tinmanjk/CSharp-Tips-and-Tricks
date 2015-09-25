namespace ChangingHashCode
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override int GetHashCode()
        {
            // Non-readonly property referenced in 'GetHashCode()'
            return this.Id;
        }
    }
}
