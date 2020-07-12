﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P04Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(int[] input)
        {
            this.stones = input.ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.stones[i];
                }
            }
            for (int i = this.stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
