namespace CalculatorAndAccountManagementTask3
{
    interface ICalculator<T1, T2>
    {
        string GetSum(T1 value1, T2 value2);
        string GetDelta(T1 value1, T2 value2);
        string GetMultiply(T1 value1, T2 value2);
        string GetDivide(T1 value1, T2 value2);
    }
}
