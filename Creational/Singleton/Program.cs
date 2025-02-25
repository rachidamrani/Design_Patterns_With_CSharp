// Many singletons would be created by each thread, which is also illegal!
ParallelEnumerable.Range(0, 10000)
.ForAll(_ =>
{
    Singleton singleton = Singleton.Instance;
});


// Console.WriteLine("Before accessing instance");

// Singleton singleton1 = Singleton.Instance;

// Console.WriteLine("After accessing instance");

// Singleton singleton2 = Singleton.Instance; // Should be illegal

sealed class Singleton
{
    private static Singleton _instance = default!;
    private static object _lock = new();
    public static Singleton Instance
    {
        get
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }
    }

    private Singleton()
    {
        Console.WriteLine("Instantiating Singleton ...");
    }
}