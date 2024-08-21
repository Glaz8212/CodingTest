using System.Text;

namespace _031.RemoveChar
{
    internal class Program
    {
        // 2024.08.21
        // 문자열 my_string과 문자 letter이 매개변수로 주어집니다.
        // my_string에서 letter를 제거한 문자열을 return하도록 solution 함수를 완성해주세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120826
        public class Solution
        {
            public string solution(string my_string, string letter)
            {
                return my_string.Replace(letter, "");
                // string.Replace(a,b);
                // string내의 a를 b로 바꿈.
            }
        }
    }
}
