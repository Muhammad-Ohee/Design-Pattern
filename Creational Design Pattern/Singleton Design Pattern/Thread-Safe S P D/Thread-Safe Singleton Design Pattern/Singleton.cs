using System.Runtime.CompilerServices;

namespace Thread_Safe_Singleton_Design_Pattern
{
    public sealed class Singleton
    {
        private static int Counter = 0;
        private Singleton()
        {
            Counter++;
            Console.WriteLine("Counter Value: " + Counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }




        //Eager Loading
        /*
        private static readonly Singleton Instance = new Singleton();
        public static Singleton GetInstance
        {
            get
            {
                return Instance;
            }
        }
        */




        // Lazy Loading
        /*
        private static readonly Lazy<Singleton> Instance = new Lazy<Singleton>(() => new Singleton());
        public static Singleton GetInstance
        {
            get
            {
                return Instance.Value;
            }
        }
        */




        //Normal Process
        
        private static Singleton Instance = null;
        private static readonly object InstanceLock = new object();
        public static Singleton GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    lock (InstanceLock)
                    {
                        if (Instance == null)
                        {
                            Instance = new Singleton();
                        }
                    }
                }   
                return Instance;
            }
        }
        
    }
}