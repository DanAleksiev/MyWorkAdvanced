namespace _08.BalancedParenthesis
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();

            bool isItBalanced = false;
            Queue<char> rightHalf = new Queue<char>();
            Stack<char> leftHalf = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
                {
                if (i < input.Length / 2)
                    {
                    leftHalf.Push(input[i]);
                    }
                else
                    {
                    rightHalf.Enqueue(input[i]);
                    }
                }

            while (rightHalf.Any())
                {
                switch (rightHalf.Peek())
                    {
                    case '}':
                        if(leftHalf.Peek() == '{')
                        {
                        isItBalanced = BalanceCheck(rightHalf, leftHalf);
                        }
                    break;

                    case ']':
                    if (leftHalf.Peek() == '[')
                        {
                        isItBalanced = BalanceCheck(rightHalf, leftHalf);
                        }
                    break;

                    case ')':
                    if (leftHalf.Peek() == '(')
                        {
                        isItBalanced = BalanceCheck(rightHalf, leftHalf);
                        }
                    break;

                    }
                if (!isItBalanced)
                    {
                    Console.WriteLine("NO");
                    break;
                    }
                }
            if (isItBalanced)
                {
                Console.WriteLine("YES");
                }
            }

        private static bool BalanceCheck(Queue<char> rightHalf, Stack<char> leftHalf)
            {
            bool isItBalanced;
            leftHalf.Pop();
            rightHalf.Dequeue();
            isItBalanced = true;
            return isItBalanced;
            }
        }
    }