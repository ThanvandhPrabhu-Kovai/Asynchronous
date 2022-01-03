// C# program to illustrate the
// concept of multilevel inheritance
using System;
using System.Threading.Tasks;

// Driver Class
class Async
{

    // Main Method
    static async Task Main()
    {
        performAnAsyncOperation();
        performASynchronousTask(2);
        performASynchronousTask(4);
        await performAnAsyncOperation();
        performASynchronousTask(6);
        performASynchronousTask(8);
        await performAnAsyncOperation();
    }

    public static void performASynchronousTask(int i)
    {
        Console.WriteLine(i.ToString());
    }

    public static async Task<string> performAnAsyncOperation()
    {
        string result;
        await Task.Delay(2000);
        result = "I'm here after 2000ms";
        Console.WriteLine(result);
        return result;
    }
}