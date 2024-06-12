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


