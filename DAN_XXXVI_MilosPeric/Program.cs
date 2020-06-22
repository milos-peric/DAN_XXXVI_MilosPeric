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
            Thread t1 = new Thread(new ThreadStart(treads.GenerateMatrix));
            t1.Name = "Thread 1";
            Thread t2 = new Thread(new ThreadStart(treads.GenerateRandomNumbers));
            t2.Name = "Thread 2";
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }
    }
}
