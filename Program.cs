using System.Diagnostics;

Console.WriteLine("Hello, World!");
var rnd = new Random();
var arr = new int[100000];

for (var i = 0; i < arr.Length; i++)
{
    var currentItem = rnd.Next(1, 9);
    arr[i] = currentItem;
}

var ordinaryResult = GetOrdinarySum(arr);
var parallelResult = GetSumWithParallelEvaluation(arr);
var linqResult = GetSumWithLinq(arr);

Console.WriteLine($"Последовательное вычисление суммы. Результат: {ordinaryResult.Sum}; время вычисления: {ordinaryResult.SpentTime}");
Console.WriteLine($"Параллельное вычисление суммы. Результат: {parallelResult.Sum}; время вычисления: {parallelResult.SpentTime}");
Console.WriteLine($"Вычисление суммы с помощью Linq. Результат: {linqResult.Sum}; время вычисления: {linqResult.SpentTime}");

EvaluationResult GetOrdinarySum(int[] arr)
{
    var stopwatch = new Stopwatch();
    stopwatch.Start();
    var result = 0;

    //Evaluating items sum with for loop
    for (var i = 0; i < arr.Length; i++)
    {
        result += arr[i];
    }

    stopwatch.Stop();

    return new EvaluationResult(result, stopwatch.ElapsedMilliseconds);
}

EvaluationResult GetSumWithParallelEvaluation(int[] arr)
{
    var result = 0;
    var stopwatch = new Stopwatch();
    stopwatch.Start();

    //Evaluating items sum with Parallel
    result = arr.AsParallel().Sum(x => x);

    return new EvaluationResult(result, stopwatch.ElapsedMilliseconds);
}

EvaluationResult GetSumWithLinq(int[] arr)
{
    var result = 0;
    var stopwatch = new Stopwatch();
    stopwatch.Start();

    //Evaluating items sum with LINQ
    result = arr.Sum(x => x);

    stopwatch.Stop();

    return new EvaluationResult(result, stopwatch.ElapsedMilliseconds);
}

class EvaluationResult
{
    public EvaluationResult(long sum, long spentTime)
    {
        Sum = sum;
        SpentTime = spentTime;
    }

    public long Sum { get; }
    public long SpentTime { get; }
}