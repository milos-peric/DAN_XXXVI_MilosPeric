﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAN_XXXVI_MilosPeric
{
    class MatrixFunctions
    {
        private List<int> numbersList1 = new List<int>();
        private int[,] numbersMatrix1 = new int[100, 100];
        readonly object listlock = new object();

        /// <summary>
        /// Generates random list of numbers and adds it to multidimensional array.
        /// Also coverts multidimensional array for convinience of use.
        /// When all numbers are generated function signals other threads that they continue execution.
        /// </summary>
        public void GenerateRandomNumbers()
        {
            Random random = new Random();
            lock (listlock)
            {
                for (int i = 0; i < 100; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        numbersMatrix1[i, j] = random.Next(10, 100);
                    }
                }
                numbersList1 = numbersMatrix1.Cast<int>().ToList();
                Monitor.Pulse(listlock);
            }
        }

        /// <summary>
        /// Creates empty multidimensional array then waits untill while condition is no longer true.
        /// Matrix is then assigned values of random numbers, generated by GenerateRandomNumbers function. 
        /// </summary>
        public void GenerateMatrix()
        {
            int[,] newmat = new int[100, 100];
            lock (listlock)
            {

                while (numbersList1.Count != 10000)
                {
                    Monitor.Wait(listlock);
                }

                for (int i = 0; i < 100; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        newmat[i, j] = numbersMatrix1[i, j];
                    }
                }
            }
        }
    }
}