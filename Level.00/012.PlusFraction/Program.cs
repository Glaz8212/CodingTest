namespace _012.PlusFraction
{
    internal class Program
    {
        // 2024.08.07
        // 첫 번째 분수의 분자와 분모를 뜻하는 numer1, denom1, 두 번째 분수의 분자와 분모를 뜻하는 numer2, denom2가 매개변수로 주어집니다.
        // 두 분수를 더한 값을 기약 분수로 나타냈을 때 분자와 분모를 순서대로 담은 배열을 return 하도록 solution 함수를 완성해보세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120808
        public class Solution
        {
            // 분모의 최소공배수를 구한 뒤 통분해서 합친 후에,
            // 분자와 분모의 최대공약수가 1이 아닌지 확인하고 약분한다.
            public int gcd(int x, int y) // 유클리드 호재법을 이용한 최대공약수를 구하는 재귀 함수이다.
            {
                if (y == 0)
                    return x;
                else
                    return gcd(y, x % y);
            }
            public int lcm(int x, int y) // 두 수를 곱한 다음, 최대공약수로 나눠서 최소공배수를 구한다.
            {
                return (x * y) / gcd(x, y);
            }
            public int[] solution
                (int numer1, int denom1, int numer2, int denom2)
            {
                // 약분하기 전의 분자 구하기

                //1. 분모의 최소공배수 구하기 (리턴할 분모 구하기)(약분하기전)
                int denomAnswer = lcm(denom1, denom2);

                //2. 분자의 합 (리턴할 분자 구하기)(약분하기전)
                int y = denomAnswer / denom1;
                int z = denomAnswer / denom2;
                int numerAnswer = y * numer1 + z * numer2;

                //3. 약분이 되면 약분 하기 (현재상태는 numerAnswer/denomAnswer)
                int[] answer = new int[2];

                int i = gcd(numerAnswer, denomAnswer);
                if (i == 1)
                {
                   answer[0] = numerAnswer;
                   answer[1] = denomAnswer;
                }
                else
                {
                    answer[0] = numerAnswer / i;
                    answer[1] = denomAnswer / i;
                }
                
                return answer;
            }
        }

    }
}
