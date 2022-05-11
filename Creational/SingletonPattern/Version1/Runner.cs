namespace SingletonPattern.Version1;

public class Version1
{
    public void Run()
    {
        Console.WriteLine($"{GetType().Name} is running...");

        var instance1 = Singleton.Instance;
        var instance2 = Singleton.Instance;

        Console.WriteLine(ReferenceEquals(instance1, instance2));

        //Mutiple thread tests
        Singleton instance3 = default, instance4 = default;
        Thread thread1 = new(() =>
        {
            instance3 = Singleton.Instance;
        });
        Thread thread2 = new(() =>
        {
            instance4 = Singleton.Instance;
        });

        thread1.Start();
        thread2.Start();

        Console.WriteLine(ReferenceEquals(instance3, instance4));
    }
}
