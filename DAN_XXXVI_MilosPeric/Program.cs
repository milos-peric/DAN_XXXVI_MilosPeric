using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAN_XXXVI_MilosPeric
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixFunctions treads = new MatrixFunctions();
            //First part of the task starts here
            Thread t1 = new Thread(new ThreadStart(treads.GenerateMatrix));
            t1.Name = "Thread 1";
            Thread t2 = new Thread(new ThreadStart(treads.GenerateRandomNumbers));
            t2.Name = "Thread 2";
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            //Second part of the task starts here
            Thread t3 = new Thread(new ThreadStart(treads.WriteOddNumbersToFile));
            t3.Name = "Thread 3";
            Thread t4 = new Thread(new ThreadStart(treads.ReadFile));
            t4.Name = "Thread 4";
            t3.Start();
            t4.Start();
            t3.Join();
            t4.Join();
            
            Console.ReadKey();
        }
    }
}
