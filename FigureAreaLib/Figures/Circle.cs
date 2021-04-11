using System;

namespace FigureAreaLib.Figures
{
    /// <summary>
    /// Окружность
    /// </summary>
    class Circle : ICalcArea
    {
        // не стал использовать PI из библиотеки Math, т.к. эта проверка используется в тестах
        private const double pi = 3.14;

        public double CalcArea(params double[] values)
        {
            return pi * Math.Pow(values[0], 2);
        }
    }
}
