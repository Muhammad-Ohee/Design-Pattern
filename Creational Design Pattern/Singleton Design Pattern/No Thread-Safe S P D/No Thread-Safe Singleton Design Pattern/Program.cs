//Console.WriteLine("Hello, OS");

namespace No_Thread_Safe_Singleton_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromTeacher = Singleton.GetInstance;
            Singleton fromStudent = Singleton.GetInstance;

            fromTeacher.PrintDetails("From Teacher.");
            fromStudent.PrintDetails("From Student.");
        }
    }
}

