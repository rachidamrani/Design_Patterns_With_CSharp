ParallelEnumerable.Range(0, 10000)
.ForAll(_ =>
{
    Singleton singleton = Singleton.Instance;
});


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