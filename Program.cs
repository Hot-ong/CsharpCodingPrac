// See https://aka.ms/new-console-template for more information
global using System;
global using static System.Console;
using StringTest;
using NullableTest;
using CalculateTest;
using CaseLoopTest;
using ClassTest;


namespace CsharpCodingPrac
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StringTest_01 a = new StringTest_01();
            a.ST_01();
            NullableTest_01.NT_01();
            StringTest_01.ST_02();
            string hello = "StringTest_01>.ST_01();";
            WriteLine(hello.Append("// 이게 왜 자동완성으로 뜨는거지?"));

            CalculateTest_01 b = new CalculateTest_01();
            //b.CT_01();

            // int numChar = int.Parse("asd"); // 실행오류 발생
            // Console.ReadLine()으로 수입력을 해달라고 했는데 문자를 넣어버렸을 때
            // 이게 문잔지 숫잔지 판단하는 메서드 같은게 있으려나
            // 봐놓고 까먹네;; if 써서 int.TryParse로 판단하고 진행하면 됨

            CaseLoopTest_01 c = new CaseLoopTest_01();
            //c.CLT_01();

            //b.CT_02();

            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("TestLog.txt")); // 매개변수가 Ilogger로 돼있는데 FileLogger가 Ilogger를 상속 받았기 때문에 FileLogger를 인수로 사용 가능
            monitor.start();
        }
    }
}