namespace SquareMultiplyAlgo
{
    public static class BinaryConverter
    {
        public static string ConvertToBinary(double number)
        {
            var binary = "";

            while (number > 0)
            {
                binary = (number % 2) switch
                {
                    0 => "0" + binary,
                    _ => "1" + binary
                };

                number /= 2;
            }

            return binary;
        }

        public static double ConvertToDecimal(string binary)
        {
            var number = 0.0;
            var exponent = 0;
            foreach (var digit in binary.Reverse())
            {
                number = digit switch
                {
                    '1' => number + Math.Pow(2, exponent),
                    _ => number
                };

                exponent++;
            }

            return number;
        }
    }
}
