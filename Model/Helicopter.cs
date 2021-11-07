using System;

namespace Model
{
    /// <summary>
    /// Класс "Вертолёт".
    /// </summary>
    public class Helicopter : ICalcFuel
    {
        // Объём полных баков.
        private double _V;
        // Количество километров, пройдённых с использованием полных баков.
        private double _S;
        // Коэффициент расхода топлива. 
        private double _K;

        /// <summary>
        /// Объём баков.
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
        /// Количество километров, пройдённых с использованием полных баков { get; set; }.
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
        /// Коэффициент расхода топлива.
        /// </summary>
        public double K
        {
            set
            {
                // Если значение меньше либо равно нулю или больше единицы, то создаём исключение.
                if (value <= 0 || value > 1)
                    throw new ArgumentException(String.Format("{0} не может быть меньшей либо равной нулю или больше единицы,", K), "K");

                _K = value;
            }

            get
            {
                return _K;
            }
        }

        /// <summary>
        /// Расчёт расхода топлива на 100 км.
        /// </summary>
        /// <returns>Расход топлива на 100 км.</returns>
        public double Get()
        {
            // Расчёт расхода топлива на 100 км и возвращение результата.
            return (V / S * 100 * K);
        }
    }
}
