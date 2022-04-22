namespace SquareMultiplyAlgo
{
    public static class SquareMultiply
    {
        public static double Calculate(double baseNumber, double exponent, double mod)
        {
            var binaryExponent = BinaryConverter.ConvertToBinary(exponent);

            var resultMod = baseNumber;

            // The binary will always start with a '1'.
            // This means the first operation can be skipped because the correct result of the calculation is simply {baseNumber}^{exponent}.
            // No mathematical computation actually took place.
            binaryExponent = binaryExponent[1..];

            foreach (var digit in binaryExponent)
            {
                resultMod = digit switch
                {
                    '0' => CalculationStepWhenBinaryZero(resultMod, mod),
                    '1' => CalculationStepWhenBinaryOne(resultMod, baseNumber, mod),
                    _ => 0
                };
            }

            return resultMod;
        }

        private static double CalculationStepWhenBinaryZero(double baseNumber, double mod)
        {
            return (baseNumber * baseNumber) % mod;
        }

        private static double CalculationStepWhenBinaryOne(double resultMod, double baseNumber, double mod)
        {
            var intermediateResult = CalculationStepWhenBinaryZero(resultMod, mod);
            return (intermediateResult * baseNumber) % mod;
        }
    }
}
