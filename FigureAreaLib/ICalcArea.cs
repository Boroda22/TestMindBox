using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLib
{
    interface ICalcArea
    {
        // в метод передаются значения, на их количестве определяется тип фигуры
        double CalcArea(params double[] values);
    }
}
