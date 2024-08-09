namespace _022.FindBiggestNumAndIndex
{
    internal class Program
    {
        // 2024.08.09
        // 정수 배열 array가 매개변수로 주어질 때, 
        // 가장 큰 수와 그 수의 인덱스를 담은 배열을 return 하도록 solution 함수를 완성해보세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120899
        public int[] solution(int[] array)
        {
            int[] answer = new int[2];
            answer[0] = array.Max();
            answer[1] = Array.IndexOf(array, answer[0]);
            return answer;
        }
        static void Main(string[] args)
        {

        }
    }
}
