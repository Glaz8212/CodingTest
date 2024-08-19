namespace _026.ReverseArray
{
    internal class Program
    {
        // 2024.08.19
        // 정수가 들어 있는 배열 num_list가 매개변수로 주어집니다.
        // num_list의 원소의 순서를 거꾸로 뒤집은 배열을
        // return하도록 solution 함수를 완성해주세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120821
        public int[] solution(int[] num_list)
        {
            int[] answer = new int[num_list.Length];
            for (int i = 0; i <= num_list.Length -1 ; i++)
            {
                answer[i] = num_list[num_list.Length - i - 1];
            }
            return answer;
        }
    }
}