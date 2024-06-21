/* 

Question 1 : 

This code computes the product of two variables, 
what is the runtime of this code?
------------------------------------------
Answer : The overall time complexity is : O(b)+O(1) = O(b)

*/
class ExoBigO1
{
    public static int Product(int a, int b)  // The overall time complexity is : O(b)+O(1) = O(b)
    {
        int sum = 0; // O(1) => constant time operation
        for (int I = 0; I < b; I++) // O(b) => The loop will loop b times 
        {
            sum += a; // O(1) => : constant time operation
        }
        return sum; 
    } 
}

/* 

Question 2 : 

This code computes A ^ B, what would be the runtime?
------------------------------------------
Answer : 
The overall time complexity is : O(b)+ O(1) + O(1) = O(b)
*/

class ExoBigO2
{
    static int Power(int a, int b) //The overall time complexity is : O(b)+ O(1) + O(1) = O(b) 
    {
        
        if (b < 0) return a; // O(1) => constant time operation
        if (b == 0) return 1; // O(1) => constant time operation
        
        int sum = a; // O(1) => constant time operation
        
        for (int I = 0; I < b - 1; I++) // O(b-1) => The loop will loop b times. By ignoring constant we'll get O(b)
        {
            sum *= a; // O(1) => constant time operation
        }
        return sum;
    }

}

/* 

Question 3 : 

This code computes A % B, what would be the runtime?
------------------------------------------
Answer : The overall time complexity is : O(1) + O(1) + O(1) = O(1)

*/

class ExoBigO3
{
    public static int Mod(int a, int b) //The overall time complexity is : O(1) + O(1) + O(1) = O(1)
    {
        if (b <=a) return -1; // O(1) => constant time operation
        
        int div = a / b; // O(1) => constant time operation
        
        return a - div * b; // O(1) => constant time operation
    }

}


/* 

Question 4: 

This code computes a division between whole integers (assuming both are positive), what would be the runtime?
------------------------------------------
Answer : The overall time complexity is : O(1) + O(1) + O(a) = O(a)

*/

class ExoBigO4
{
    public static int Div(int a, int b) //The overall time complexity is : O(1) + O(1) + O(a) = O(a)
    {
        int count = a; // O(1) => constant time operation
        int sum = b; // O(1) => constant time operation
        
        while (sum <= a) // O(a) => The loop will run a time until the condirion breaks.
        {
            sum += b; // O(1) => constant time operation
            count++;// O(1) => constant time operation
        }
        return count;
    }

}


/* 

Question 5: 

The following code calculates the square root of an integer. 
If the number is not a perfect square (there is no whole square root), then return -1. 
If N is 100, first guess if N is 50. Too high? Try something lower, halfway between 1 and 50, etc. What is the big-o?
------------------------------------------
Answer : The overall time complexity is : O(log n) 

*/

class ExoBigO5
{
    public static int Sqrt(int n) { // Since the main function only calls recursively the helper function, so it's runtime is O(log n)
    return SqrtHelper(n, 1, n); // O(log n)
}
public static int SqrtHelper(int n, int min, int max) { // Overall the function has a O(log n) runtime.
    if (max < min) return -1; // O(1) => constant time operation 
    int guess = (min + max) / 2; // O(1) => constant time operation
    if (guess * guess == n) { // O(1) => constant time operation
        return guess; 
    } else if (guess *guess <n) {
        return SqrtHelper(n, guess + 1, max) ; // O(log n) => The function is recursively called with a reduced range.
    } else { 
        return SqrtHelper(n, min, guess - 1); // O(log n) => The function is recursively called with a reduced range.
    }
}
}


/* 

Question 6: 

The following code calculates the square root of an integer. 
If the number is not a perfect square (there is no whole square root), then return -1. 
It does so by trying larger and larger numbers until it finds the correct value (or is too high).
What is your runtime?
------------------------------------------
Answer : The overall time complexity is : O(n) 

*/

class ExoBigO6
{
    public static int Sqrt(int n) { // O(n)
        
        for (int guess = 1; guess * guess < n; guess++) { // O(n) Since the loop will run n times.
            if (guess * guess == n) return guess;
        }
        return -1; // O(1) => constant time operation 
    }
}


/* 

Question 7: 

If a binary search tree (BST) is not balanced, 
how long could it take in the worst case to find an item?
------------------------------------------
Answer : The overall time complexity is : O(n) as it may go through all the nodes in the worst case

*/


/* 

Question 8: 

What would be the worst case if we are looking for a value in a binary tree (Binary Tree - BT) that is not ordered?
------------------------------------------
Answer : The overall time complexity is : O(n) as it may go through all the nodes in the worst case

*/


/*
Question 9: 

The appendToNew method adds a value to an array by creating a new, longer array and returning this longer array. 
How long does it take to copy the array?
------------------------------------------
Answer : runtime is O(n²)
*/

class ExoBigO9
{
    public static int[] CopyArray(int[] array)
    {

        int[] copy = []; // O(1)
        for (int i = 0; i < array.Length; i++) // O(arr.length) => O(n) * O(n) function runtime => Overall the runtime of the loop is O(n²) 
        {
            copy = AppendToNew(copy, array[i]); // O(n)
        }
        return copy;
    }

    public static int[] AppendToNew(int[] array, int value) { // runtime = O(n)
        
        int[] bigger = new int[array.Length + 1]; // O(1)
        
        for (int I = 0; I < array. Length; I++) { // O(arr.length) => O(n)
            bigger[I] = array[I]; // O(1)
        }
        
        bigger[bigger.Length - 1] = value; // O(1)
        
        return bigger;
    }
}


/*
Question 10:

The following code adds the digits of a number. What is your runtime?
------------------------------------------
Answer : O(log n)
*/

class ExoBig10
{
    public static int SumDigits(int n, int e) { // Overall, the runtime complexity is O(log n)
        
        int sum = 0; // O(1)

        while (n > e) { // O(log n) => The number of iterations required is proportional to the number of digits in n, which is logarithmic in the value of n.
            sum += n % 10; // O(1)
            n /= 10; // O(1)
        } 
        return sum; // O(1)
    }

}
