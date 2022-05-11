namespace SingletonPattern.Version4
{
    public class Singleton
    {
        //缺点：仅适用于构造器无参的单例模式，不支持参数化的构造方法，因为静态构造方法不允许传递参数
        public static readonly Singleton Instance = new Singleton();
        private Singleton() { }
    }
    //上面的Singleton类等价于下面类
    //public class Singleton
    //{
    //    private static readonly Singleton Instance;
    //    static Singleton() //.net的类型初始化机制会保证只会有一个线程执行静态构造方法，避免多个线程执行静态构造方法
    //    {
    //        Instance = new Singleton();
    //    }
    //    private Singleton() { }
    //}
}