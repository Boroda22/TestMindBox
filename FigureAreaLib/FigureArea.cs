using FigureAreaLib.Figures;

using System;



// BAD SMELL
// На основании количества параметров, определяем тип фигуры
// в качестве создания объектов можно было бы использовать фабрику.
// Можно не использовать интерфейс, а определить базовый класс, например, фигура,
// в котором определен метод расчета площади, а в потомках его переопределять
namespace FigureAreaLib
{
    public static class FigureArea
    {
        public static double GetArea(params double[] values)
        {
            double result;
            
            switch (values.Length)
            {
                case 1:
                {
                    result = new Circle().CalcArea(values);
                    break;
                }
                case 3:
                {
                    result = new Triangle().CalcArea(values);
                    break;
                }
                default:
                {
                    // не могу сказать насколько верно возвращать такое значение в качестве ошибки
                    throw new InvalidOperationException("Неверное количество параметров, должно быть 1 либо 3 параметра");
                }
            }
            return result;
        }
    }
}
