sealed class Singleton
{
    private static readonly Lazy<Singleton> _lazySingleton = new Lazy<Singleton>(() => new Singleton());

    public static Singleton Instance => _lazySingleton.Value;


    private Singleton()
    {
        Console.WriteLine("Instantiating Singleton ...");
    }
}