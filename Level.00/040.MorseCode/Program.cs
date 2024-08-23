using System.Text;

namespace _040.MorseCode
{
    internal class Program
    {
        // 2024.08.23
        // 머쓱이는 친구에게 모스부호를 이용한 편지를 받았습니다.
        // 그냥은 읽을 수 없어 이를 해독하는 프로그램을 만들려고 합니다.
        // 문자열 letter가 매개변수로 주어질 때, letter를 영어 소문자로 바꾼 문자열을 return 하도록
        // solution 함수를 완성해보세요.
        // 모스부호는 다음과 같습니다.
        /* morse = { 
                    '.-':'a','-...':'b','-.-.':'c','-..':'d','.':'e','..-.':'f',
                    '--.':'g','....':'h','..':'i','.---':'j','-.-':'k','.-..':'l',
                    '--':'m','-.':'n','---':'o','.--.':'p','--.-':'q','.-.':'r',
                    '...':'s','-':'t','..-':'u','...-':'v','.--':'w','-..-':'x',
                    '-.--':'y','--..':'z'
                    } */
        // https://school.programmers.co.kr/learn/courses/30/lessons/120838
        public class Solution
        {
            // answer스트링빌더 만들고
            // list로 모스부호 담아서,
            // 입력한 모스부호 split 해서 list에서 찾고,
            // 인덱스 번호에 + 해서 아스키
            public string solution(string letter)
            {
                StringBuilder answer = new StringBuilder();
                List<string> morse = new List<string>() { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
                string[] splitLetter = letter.Split(' ');

                foreach (string str in splitLetter)
                {
                    int index = morse.IndexOf(str);
                    answer.Append((char)('a' + index));
                }
                return answer.ToString();
            }
        }
    }
}
