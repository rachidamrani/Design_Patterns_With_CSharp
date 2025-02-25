sealed class Singleton
{

    public static Singleton Instance => Nested.Instance;
    private class Nested
    {
        internal static Singleton Instance { get; } = new();
        static Nested() { }
    }

    private Singleton() { }

    static Singleton()
    {
        Console.WriteLine("Instantiation Singleton..");
    }
}