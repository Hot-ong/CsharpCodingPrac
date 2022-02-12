namespace NullableTest
{
    public static class NullableTest_01
    {
        static int? testVar01 = null;

        public static void NT_01()
        {
            //WriteLine(testVar01.Value);   // 예외처리가 필요하다고 에러 뜸
            WriteLine(testVar01);   // 콘솔에 아무것도 안 뜸
        }
    }
}
