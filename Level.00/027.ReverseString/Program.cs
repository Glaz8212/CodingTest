namespace _027.ReverseString
{
    internal class Program
    {
        // 2024.08.20
        // 문자열 my_string이 매개변수로 주어집니다.
        // my_string을 거꾸로 뒤집은 문자열을 return하도록 solution 함수를 완성해주세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120822
        public class Solution
        {
            public string solution(string my_string)
            {
                char[] chars = my_string.ToCharArray();
                char[] answerChars = new char[chars.Length];
                for (int i = 0; i<= my_string.Length - 1; i  ++)
                {
                    answerChars[i] = chars[my_string.Length - i - 1];
                }
                string answer = new string(answerChars);
                return answer;
            }
        }
    }
}