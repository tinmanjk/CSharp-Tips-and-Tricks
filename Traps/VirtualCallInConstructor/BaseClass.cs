namespace VirtualCallInConstructor
{
    public abstract class BaseClass
    {
        protected BaseClass()
        {
            // Virtual member call in constructor
            this.AddToDatabase();
        }

        protected virtual void AddToDatabase()
        {
        }
    }
}
