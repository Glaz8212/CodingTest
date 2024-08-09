namespace _021.GetAverage
{
    internal class Program
    {
        // 2024.08.09
        // 정수 배열 numbers가 매개변수로 주어집니다.
        // numbers의 원소의 평균값을 return하도록 solution 함수를 완성해주세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120817
        public double solution(int[] numbers)
        {
            double answer = 0;
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            answer = (float)sum / numbers.Length;
            return answer;
        }
        static void Main(string[] args)
        {

        }
    }
}
