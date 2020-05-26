namespace Coursach.Calculators
{
    public interface IStipendyCalculator
    {
        decimal Calculate(decimal baseAmount, decimal coeff);
    }
}