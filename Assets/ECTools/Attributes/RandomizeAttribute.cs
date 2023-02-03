using UnityEngine;

namespace ECTools
{
    public class RandomizeAttribute : PropertyAttribute
    {       
        public float min;
        public float max;

        public RandomizeAttribute(float _initialMin, float _initialMax)
        {
            min = _initialMin;
            max = _initialMax;
        }
    }
}