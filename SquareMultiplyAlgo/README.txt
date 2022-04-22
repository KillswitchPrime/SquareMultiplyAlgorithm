This program calculates the modulo of potentially extremely large numbers extremely quickly.
The algorithm is based on the Square Multiply algorithm.

Example of how the program works:

Calculate 3^45 % 7

First convert exponent (45) to binary.
	45 = 101101

Then use square multiply algo to get answer.

We skip the first digit (read from left to right),
This is because the result is simply base number (3) to the power of 1, 3^1.

If the next digit is a '0' then we multiply the base number (3) with itself, and do modulo on this result.
	3*3 = 9 (square the result from previous step (base number if first step))
	9 % 7 = 2

We then use this number for the next digit.

If the next digit is a '1', we start by doing the same operation as with a '0' digit, but add an additional step.
	2*2 = 4 (square the result from previous step)
	4 % 7 = 3

	3*3 = 9 (multiply the result from previous step with the base number)
	9 % 7 = 2

 Continue this process until every digit in the binary has been calculated.

 Since every single step only calculates very small numbers, the algorithm is extremely fast, even when dealing with astronomical numbers.