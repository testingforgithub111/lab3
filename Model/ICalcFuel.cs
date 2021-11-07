namespace Model
{
    /// <summary>
    /// Интерфейс "Затраченное топливо".
    /// </summary>
    public interface ICalcFuel
    {
        /// <summary>
        /// Получить расчёт топлива на 100 км.
        /// </summary>
        double Get();
    }
}
