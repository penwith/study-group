namespace Two
{
    public interface IIterator
    {
        bool HasNext { get; }
        object Next { get; }
    }
}
