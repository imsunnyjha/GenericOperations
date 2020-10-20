using System;
using System.Collections.Generic;
using System.Text;

namespace OperationsWithGenerics
{
    class GenericOperation<TType>where TType:IComparable
    {
        public TType[] value;
        public GenericOperation(TType[] value)
        {
            this.value = value;    
        }
        public TType[] Sort(TType[] values)
        {
            Array.Sort(values);
            return values;
        }
        public TType MaxValue(params TType[] values)
        {
            var sortedValues = Sort(values);
            return sortedValues[^1];
        }
        public TType Maxmethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void PrintMax()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum: " + max);
        }
    }
}
