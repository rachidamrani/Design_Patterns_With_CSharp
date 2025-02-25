ParallelEnumerable.Range(0, 10000)
.ForAll(_ =>
{
    Singleton singleton = Singleton.Instance;
});


sealed class Singleton
{
    private static Singleton _instance = default!;
    private static readonly Lazy<Singleton> _lazySingleton = new Lazy<Singleton>(() => new Singleton());

    public static Singleton Instance => _lazySingleton.Value;


    private Singleton()
    {
        Console.WriteLine("Instantiating Singleton ...");
    }
}