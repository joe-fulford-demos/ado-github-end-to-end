namespace mega_project_api
{
    public class ExampleClass
    {
        public string ExampleMethod()
        {
            return "Hello World!";
        }

        // Get fibonacci sequence for gove length
        public int[] Fibonacci(int length)
        {
            int[] sequence = new int[length];
            if (length == 0)
            {
                return sequence;
            }
            else if (length == 1)
            {
                sequence[0] = 0;
                return sequence;
            }
            else if (length == 2)
            {
                sequence[0] = 0;
                sequence[1] = 1;
                return sequence;
            }
            else
            {
                sequence[0] = 0;
                sequence[1] = 1;
                for (int i = 2; i < length; i++)
                {
                    sequence[i] = sequence[i - 1] + sequence[i - 2];
                }
                return sequence;
            }
        }


    }
}
