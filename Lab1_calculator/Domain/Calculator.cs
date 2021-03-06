﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.WinFormsLab1.Domain 
{
    public class Calculator : ICalculator
    {
        private double memory;
        private double result;

        private double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        public double Calc_sin(double x)
        {
            return Math.Sin(DegreesToRadians(x));
        }

        public double Calc_cos(double x)
        {
            return Math.Cos(DegreesToRadians(x));
        }

        public double Calc_tg(double x)
        {
            return Math.Tan(DegreesToRadians(x));
        }

        public double Calc_ctg(double x)
        {
            return 1 / Math.Tan(DegreesToRadians(x));
        }

        public double Calc_sum(double x)
        {
            return result + x;
        }

        public double Calc_sub(double x)
        {
            return result - x;
        }

        public double Calc_mul(double x)
        {
            return result * x;
        }

        public double Calc_div(double x)
        {
            return result / x;
        }

        public double Calc_sqrtX(double x)
        {
            return Math.Pow(result, 1 / x);
        }

        public double Calc_sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public double Calc_degreeX(double x)
        {
            return Math.Pow(result, x);
        }

        public double Calc_sq(double x)
        {
            return Math.Pow(x, 2);
        }

        public void PushX(double x)
        {
            result = x;
        }

        public void ClearResult()
        {
            result = 0;
        }

        public double Show_MRC()
        {
            return memory;
        }

        public void Clear_MRC()
        {
            memory = 0;
        }

        public void Memory_plus(double x)
        {
            memory += x;
        }

        public void Memory_minus(double x)
        {
            memory -= x;
        }
    }
}
