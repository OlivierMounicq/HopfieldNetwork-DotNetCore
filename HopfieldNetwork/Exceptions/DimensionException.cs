using System;

namespace HopfieldNetwork.Exceptions
{
    public class DimensionException : Exception
    {
        public DimensionException(int rowQuantity, int columnQuantity)
            :base(string.Format("The row quantity ({0}) is not equal to the column quantity ({1}) ", rowQuantity, columnQuantity))
        {}        
    }
}