﻿using System;

namespace compressor.Kohonen
{
    public class Neuron
    {
        private int dim;
        private double [] w;

        public double this[int index]
        {
            get { return w[index]; }
        }

        public Neuron(int dim)
        {
            this.dim = dim;
            w = new double[dim];
        }

        public double Deviation(double [] v) 
        {   
            double sum = 0;
            for (int i = 0; i <  v.Length; i++) {
                sum += (v[i] - w[i]) * (v[i] - w[i]);
            }
            return sum;
        }

        /// <summary>
        /// Обучение нейрона
        /// </summary>
        /// <param name="c"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public double[] Train(double c, double[] v)
        {
            double [] res = new double[dim];
    
            for (int i = 0; i < dim; i++) 
            {
                w[i] += Math.Round(c * (v[i] - this.w[i]));
                res[i] = w[i];                
            }
            return res; 
        }
    }
}