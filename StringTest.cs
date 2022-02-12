namespace StringTest
{
    public class StringTest_01
    {
        private string b = "녕하세요";
        public void ST_01()
        {
            string a = "안";

            Write(a);
            WriteLine(b);   // this.b 가 아니라 걍 b를 써도 되는건 내부라서 그런가? 아니면 이 메서드에 b라는 같은 이름의 매개변수를 받아서 그거 가지고 뭐 할 때 안 헷갈리구로 this를 붙여야 되는건가
        }
        public static void ST_02()
        {
            WriteLine("{0,0}DEF", "ABC");
            WriteLine("{0,-1}DEF", "ABC");
            WriteLine("{0,-2}DEF", "ABC");
            WriteLine("{0,-3}DEF", "ABC");
            WriteLine("{0,-4}DEF", "ABC");
            WriteLine("{0,-5}DEF", "ABC");
            WriteLine("{0,-6}DEF", "ABC");
            WriteLine("{0,-7}DEF", "ABC");
            WriteLine("{0,-8}DEF", "ABC");
            WriteLine("{0,-9}DEF", "ABC");
            WriteLine("{0,-10}DEF", "ABC");
        }
    }

    public static class StringTest_02
    {
        public static string Append(this string myStr, string apdStr)
        {
            return myStr + apdStr;
        }
    }
}