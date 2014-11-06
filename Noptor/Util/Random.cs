using UnityEngine;
using System.Linq;
using System.Collections;
using System;

namespace Noptor.Util
{
    public class Random
    {

        /// <summary>
        /// Рандом, заданный процентной вероятностью.
        /// </summary>
        /// <returns>Ключ в массиве переданных весов, на который выпал рандомайзер.</returns>
        /// <param name="weights">Массив весов в процентах.</param>
        public static int PercentRandom(int[] weights)
        {
            int[] weightSorted = weights.OrderBy(t => t).ToArray();

            int over = weightSorted.Sum();
            int rand = UnityEngine.Random.Range(0, over);
            
            int top = 0;
            
            for (int i = 0; i < weightSorted.Length; i++) {
                top += weightSorted[i]; 
                
                if(rand < top)
                {
                    return  Array.FindIndex(weights, w => w == weightSorted[i]);
//                    int[] matches = Array.FindAll(weights, t => t == weights[i]);
                }
            }

            return weights.Length - 1;
        }

    }
}