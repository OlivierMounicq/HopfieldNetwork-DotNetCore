using System;

namespace HopfieldNetwork.Exceptions
{
    public class MultiplicationMatrixByVectorDimensionException : Exception
    {
        public MultiplicationMatrixByVectorDimensionException(string message)
            :base(message)
        { }
    }
}