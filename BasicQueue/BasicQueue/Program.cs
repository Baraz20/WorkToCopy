using System;

namespace BasicQueue
{
    class Program
    {
        public static int SumQ(Queue<int> Q)
        {
            Queue<int> temp = Q.CopyQ();
            int Sum = 0;
            while (!temp.IsEmpty())
            {
                Sum += temp.Remove();
            }
            return Sum;
        }
        public static int MaxQ(Queue<int> Q)
        {
            Queue<int> temp = Q.CopyQ();
            int Max = temp.Remove();
            while (!temp.IsEmpty())
            {
                if (temp.Head()>Max)
                {
                    Max = temp.Head();
                }
                temp.Remove();
            }
            return Max;
        }
        public static Queue<int> EvenCopy(Queue<int> Q)
        {
            Queue<int> Temp = Q.CopyQ();
            Queue<int> Sol = new Queue<int>();
            while (!Temp.IsEmpty())
            {
                if (Temp.Head()%2==0)
                {
                    Sol.Insert(Temp.Head());
                }
                Temp.Remove();
            }
            return Sol;
        }
        public static void MoveMax2Last(Queue<int> Q)
        {
            Queue<int> temp = new Queue<int>();
            int Max = MaxQ(Q);
            while (!Q.IsEmpty())
            {
                temp.Insert(Q.Remove());      
            }
            while (!temp.IsEmpty())
            {
                if (temp.Head()!=Max)
                {
                    Q.Insert(temp.Head());
                }
                temp .Remove();
            }
            Q.Insert(Max);
        }
        static void Main(string[] args)
        {
            Queue<int> Q = new Queue<int>();
            Q.Insert(4);
            Q.Insert(1);
            Q.Insert(9);
            Q.Insert(4);
            Console.WriteLine("Q:"+Q);
            Console.WriteLine("Sum:"+SumQ(Q));
            Console.WriteLine("Max:"+MaxQ(Q));
            Console.WriteLine("Even Queue:"+EvenCopy(Q));
            MoveMax2Last(Q);
            Console.WriteLine("Moved Max To Last:"+Q);
        }
    }
}
