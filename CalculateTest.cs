namespace CalculateTest
{
    internal partial class CalculateTest_01
    {
        public void CT_01()
        {
            Write("사각형의 넓이 입력 : ");
            string width = ReadLine();

            Write("사각형의 높이 입력 : ");
            string height = ReadLine();

            int area = int.Parse(width) * Convert.ToInt32(height);
            WriteLine($"{"사각형의"} 넓이 {"출력 : "}" + area);
        }
    }

        
    internal partial class CalculateTest_01
    { 
        public void CT_02()
        {
            bool correctInput = false;
            bool notNum = false;
            long sum = 0;
            do
            {
                Write("\n더하기를 수행할 숫자들을 콤마(,)로 구분하여 입력해 주세요\n>> ");
                string inputCheck = ReadLine();
                if(inputCheck == null)
                {
                    WriteLine("값을 입력해 주세요");
                    continue;
                }

                string[] arr = inputCheck.Split(new string[] { "," }, StringSplitOptions.None);
                long[] nums = new long[arr.Length];
                for(int i = 0; i < arr.Length; i++)
                {
                    if (long.TryParse(arr[i], out long out_i))
                    {
                        nums[i] = out_i;
                    }
                    else
                    {
                        notNum = true;
                        break;
                    }
                }

                if(notNum)
                {
                    WriteLine("숫자를 입력해 주세요");
                    notNum = false;
                    continue;
                }

                for(int i = 0; i < arr.Length; i++)
                {
                    sum += nums[i];
                }

                //WriteLine("입력한 수들의 합은 " + "{0:N}" + "입니다.", sum);
                WriteLine($"입력한 수들의 합은 {sum:N0} 입니다."); // {~:N}은 자릿수에 , 넣는 역할. 근데 N만 쓰면 소수점 2자리까지 표기됨. 그거 없애려면 {~:N0} 이렇게 하면 됨

                correctInput = true;
            } while (!correctInput);
        }
    }
}
