using System;
using System.Collections.Generic;

namespace HopfieldNetwork.Mathematics
{
    public abstract class Vector
    {
        private readonly double[] vector;

        public double this[int i]
        {
            get => vector[i];
            set => vector[i] = value;
        }

        public int Length
        {
            get => vector.Length;
        }

        public Vector(Vector v)
        {
            this.vector = new double[v.Length];
            for(var idx = 0; idx < v.Length; idx++)
            {
                this.vector[idx] = v[idx];            
            }
        }

        public Vector(int length)
            => this.vector = new double[length];

        public Vector(double[] vector)
            => this.vector = vector;        
    }
}