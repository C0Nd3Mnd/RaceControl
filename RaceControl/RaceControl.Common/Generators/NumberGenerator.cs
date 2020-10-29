﻿using System.Collections.Generic;

namespace RaceControl.Common.Generators
{
    public class NumberGenerator : INumberGenerator
    {
        private readonly List<long> _numbers = new List<long>();
        private readonly object _numbersLock = new object();

        public long GetNextNumber()
        {
            var number = 0;

            lock (_numbersLock)
            {
                while (true)
                {
                    number++;

                    if (!_numbers.Contains(number))
                    {
                        _numbers.Add(number);
                        _numbers.Sort();

                        return number;
                    }
                }
            }
        }

        public void RemoveNumber(long number)
        {
            lock (_numbersLock)
            {
                _numbers.Remove(number);
            }
        }
    }
}