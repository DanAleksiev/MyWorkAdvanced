
using System;
using System.Diagnostics;

int n = 100000000; //manipulate to see the speed of the program
int[] arr = Enumerable.Range(0, n).ToArray();
ConstantComplexity(n, arr);
LinearComplexity(n, arr);
QuadraticComplexity(n, arr);
ExponentialComplexity(n, arr);
ExponentialFactorialComplexity(n,arr);
static void ConstantComplexity(int n, int[] array)
    {
    HashSet<int> set = new(array);
    Stopwatch watch = Stopwatch.StartNew();

    watch.Start();
    for (int i = 0; i < n; i++)
        {
        set.Contains(i);
        }
    watch.Stop();
    Console.WriteLine($"O(1) {watch.ElapsedMilliseconds}");
    }
static void LinearComplexity(int n, int[] array)
    {
    List<int> list = new(array);
    Stopwatch watch = Stopwatch.StartNew();

    watch.Start();
    for (int i = 0; i < n; i++)
        {
        list.Contains(i); // array or list 
        }
    watch.Stop();
    Console.WriteLine($"O(n) {watch.ElapsedMilliseconds}");
    }
static void QuadraticComplexity(int n, int[] array)
    {
    List<int> list = new();
    Stopwatch watch = Stopwatch.StartNew();
    int counter = 0;
    watch.Start();
    for (int i = 0; i < n; i++)
        {
        for (int y = 0; y < n; y++)
            {
            counter++;
            }
        }
    watch.Stop();
    Console.WriteLine($"O(n^2) {watch.ElapsedMilliseconds}");
    }
static void ExponentialComplexity(int n, int[] array)
    {
    List<int> list = new();
    Stopwatch watch = Stopwatch.StartNew();
    ExponentialFunction(n);
    watch.Stop();
    Console.WriteLine($"O(2^n) {watch.ElapsedMilliseconds}");
    }
static int ExponentialFunction(int n)
    {
    if ( n <= 0)
        {
        return 1;
        }
    return ExponentialFunction(n - 1) + ExponentialFunction(n - 2);
    }
static void ExponentialFactorialComplexity(int n, int[] array)
    {
    List<int> list = new();
    Stopwatch watch = Stopwatch.StartNew();
    ExponentialFactorialFunction(n);
    watch.Stop();
    Console.WriteLine($"O(n!) {watch.ElapsedMilliseconds}");
    }
static int ExponentialFactorialFunction(int n)
    {
    if (n <= 0)
        {
        return 1;
        }
    int result = 0;
    for (int i = 0; i < n; i++)
        {
        result += ExponentialFactorialFunction(n - 1);
        }
    return result;
    }