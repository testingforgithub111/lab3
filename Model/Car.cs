using System;

namespace Model
{
    /// <summary>
    /// Класс "Машина".
    /// </summary>
    public class Car : ICalcFuel
    {
        // Объём полного бака.
        private double _V;
        // Количество километров, пройдённых с использованием полного бака.
        private double _S;

        /// <summary>
        /// Объём бака.
        /// </summary>
        public double V
        {
            set
            {
                // Если значение меньше либо равно нулю, то создаём исключение.
                if (value <= 0)
                    throw new ArgumentException(String.Format("{0} не может быть меньшей или равной нулю,", V), "V");

                _V = value;
            }

            get
            {
                return _V;
            }
        }

        /// <summary>
        /// Количество километров, пройдённых с использованием полного бака.
        /// </summary>
        public double S
        {
            set
            {
                // Если значение меньше либо равно нулю, то создаём исключение.
                if (value <= 0)
                    throw new ArgumentException(String.Format("{0} не может быть меньшей или равной нулю,", S), "S");

                _S = value;
            }

            get
            {
                return _S;
            }
        }

        /// <summary>
        /// Расчёт расхода топлива на 100 км.
        /// </summary>
        /// <returns>Расход топлива на 100 км.</returns>
        public double Get()
        {
            // Расчёт расхода топлива на 100 км и возвращение результата.
            return (V / S * 100);
        }
    }
}
