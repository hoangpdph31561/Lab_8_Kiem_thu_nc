namespace Code
{
    public class Calculate
    {
        public double ScoreGPA(double math, double science, double chemistry)
        {
            if (math < 0 || math > 10 || science < 0 || science > 10 || chemistry < 0 || chemistry > 10)
            {
                throw new ArgumentOutOfRangeException("Invalid input");
            }
            return (math + science + chemistry) / 3;
        }
        public int Sum(int n)
        {
            if (n < 1)
            {
                throw new ArgumentOutOfRangeException("Invalid input");
            }
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

    }
}
