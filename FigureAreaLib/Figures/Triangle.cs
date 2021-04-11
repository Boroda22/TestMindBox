using System;

namespace FigureAreaLib.Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    class Triangle : ICalcArea
    {
        public double CalcArea(params double[] values)
        {
            double perimetr = 0.5 * (values[0] + values[1] + values[2]);
            return Math.Sqrt(perimetr * (perimetr - values[0]) * (perimetr - values[1]) * (perimetr - values[2]));
        }

    }
}
