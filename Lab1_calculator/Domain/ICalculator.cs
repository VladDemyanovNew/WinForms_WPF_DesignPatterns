using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.WinFormsLab1.Domain
{
    interface ICalculator
    {
        //  тригонометрические операции
        double Calc_sin(double x);
        double Calc_cos(double x);
        double Calc_tg(double x);
        double Calc_ctg(double x);
        //  арифметические операции
        double Calc_sum(double x);
        double Calc_sub(double x);
        double Calc_mul(double x);
        double Calc_div(double x);
        //  степенные операции
        double Calc_sqrtX(double x);      // извлечение корня степени x
        double Calc_sqrt(double x);       // извлечение квадратного корня
        double Calc_degreeX(double x);    // возведение в степень x
        double Calc_sq(double x);         // возведение в квадрат
        //  дополнительные операции
        void PushX(double x);
        void ClearResult();
        //  операции хранения
        double Show_MRC();
        void Clear_MRC();
        void Memory_plus(double x);
        void Memory_minus(double x);
    }
}
