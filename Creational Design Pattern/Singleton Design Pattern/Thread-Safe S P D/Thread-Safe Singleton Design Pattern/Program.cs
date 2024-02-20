//Console.WriteLine("Hello, OS");

namespace Thread_Safe_Singleton_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //The following Code will Invoke both methods Parallely
            //using two different Threads

            //Let us Assume PrintTeacherDetails method is Invoked by Thread-1
            //Let us Assume PrintStudentDetails method is Invoked by Thread-2

            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentDetails()
                );
        }

        private static void PrintTeacherDetails()
        {
            //Thread-1 Calling the GetInstance Method of the Singleton class
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentDetails()
        {
            //At the same time, Thread-2 also Calling the GetInstance Method of the Singleton Class
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }


}

