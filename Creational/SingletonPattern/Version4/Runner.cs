namespace SingletonPattern.Version4;

public class Version4
{
    public void Run()
    {
        Console.WriteLine($"{GetType().Name} is running...");

        var instance1 = Singleton.Instance;
        var instance2 = Singleton.Instance;

        Console.WriteLine(ReferenceEquals(instance1, instance2));

        //Mutiple thread tests
        Thread thread1 = new(() =>
        {
            instance1 = Singleton.Instance;
        });
        Thread thread2 = new(() =>
        {
            instance2 = Singleton.Instance;
        });

        thread1.Start();
        thread2.Start();

        Console.WriteLine(ReferenceEquals(instance1, instance2));
    }
}
