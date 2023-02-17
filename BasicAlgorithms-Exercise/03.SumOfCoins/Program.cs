int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int sum = int.Parse(Console.ReadLine());

coins = coins.OrderByDescending(x => x).ToArray();
Dictionary<int, int> coinsTaken = new Dictionary<int, int>();
int reachedSum = 0;
int coinsCount = 0;
while (reachedSum < sum)
    {
    for (int i = 0; i < coins.Length; i++)
        {
        if (coins[i] + reachedSum <= sum)
            {
            if (!coinsTaken.ContainsKey(coins[i]))
                {
                coinsTaken[coins[i]] = 0;
                }
            coinsTaken[coins[i]]++;
            coinsCount ++;
            reachedSum += coins[i];
            }
        }
    }

Console.WriteLine($"Numbers of coins to take: {coinsTaken}");
foreach(var coin in coinsTaken)
    {
    Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
    }