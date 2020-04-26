using System;
using System.Globalization;

namespace Methods_9.SectionExam
{
    public class PropertyTaxCalculator
    {
        private const decimal IncreaseAllPropertyAssessedPercentage = 2.7M;
        private const decimal taxExemption = 25000M;
        private const decimal millageRatePerEvery1000 = 10.03M;

        private readonly string _propertyAddress;
        private readonly decimal _lastYearAssessedValue;
        private readonly decimal _currentAssessedValue;
        public  decimal TaxableValue { get; }


        public PropertyTaxCalculator(string propertyAddress, decimal lastYearAssessedValue)
        {
            _propertyAddress = propertyAddress;
            _lastYearAssessedValue = lastYearAssessedValue;
            _currentAssessedValue = CalculateCurrentAssessedValue();
            TaxableValue = CalculateTaxableValue();
        }

        private decimal CalculateTaxableValue()
        {
            var taxableValue = _currentAssessedValue - taxExemption;
            return taxableValue < 0 ? 0 : taxableValue;
        }

        private decimal CalculateCurrentAssessedValue()
        {
            var currentAssessedValue = _lastYearAssessedValue +
                                       _lastYearAssessedValue * IncreaseAllPropertyAssessedPercentage / 100;
            return currentAssessedValue;
        }

        private string ToCurrency(decimal value)
        {
            return  string.Format(new CultureInfo("ru-RU", false), "{0:c2}", value);
        }

        public decimal returnCurrentAssessedValue()
        {
            return _currentAssessedValue;
        }

        public decimal CalculateCurrentYearTax()
        {
            if (_currentAssessedValue <= taxExemption)
            {
                return 0M;
            }

            var currentYearTax = Math.Truncate(TaxableValue / 1000) * millageRatePerEvery1000;

            return currentYearTax;
        }

        public override string ToString()
        {
            return $"Property Address:{_propertyAddress}\n" +
                   $"Last Year Assessed Value: {ToCurrency(_lastYearAssessedValue)}\n" +
                   $"Current Assessed Value: {ToCurrency(_currentAssessedValue)}\n" +
                   $"Exemption:{ToCurrency(taxExemption)}\n" +
                   $"Taxable Value: {ToCurrency(TaxableValue)}\n" +
                   $"Millage Rate (per 1000P.): {ToCurrency(millageRatePerEvery1000)}\n" +
                   $"Taxes Due: {ToCurrency(CalculateCurrentYearTax())}\n";
        }
    }
}