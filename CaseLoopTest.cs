namespace CaseLoopTest
{
    internal class CaseLoopTest_01
    {
        public void CLT_01()
        {
            bool correctInput = false;
            int score = 0;
            do
            {
                Write("점수를 입력 해주세요 : ");
                string inputCheck = ReadLine();
                if (int.TryParse(inputCheck, out int out_i))
                {
                    if (out_i <= 100 && out_i >= 0)
                    {
                        score = out_i;
                        correctInput = true;
                    }
                    else
                        WriteLine("0점에서 100점 사이의 점수를 입력해주세요\n");
                }
                else
                    WriteLine("숫자를 입력해주세요\n");
                //score = Convert.ToInt32(ReadLine());
                //int score = int.Parse(Console.ReadLine());
            } while (!correctInput);
            correctInput = false;

            bool repeated = false;
            do
            {
                Write("재수강인가요? (y/n) : ");
                string line = ReadLine();
                switch (line)
                {
                    case "y":
                    case "Y":
                        correctInput = true;
                        repeated = true;
                        break;

                    case "n":
                    case "N":
                        correctInput = true;
                        repeated = false;
                        break;

                    case "":
                        WriteLine("값을 입력해 주세요");
                        break;

                    default:
                        WriteLine("y/n 으로 입력해 주세요");
                        break;
                }
            } while (!correctInput);

            string grade = (int)(Math.Truncate(score / 10.0) * 10) switch
            {
                90 when repeated == true => "B+",
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F",
            };

            WriteLine($"학점 : {grade}");
        }

        public int CLT_02(params int[] arry)
        {
            Write("Summing... ");
            int sum = 0;

            for (int i = 0; i < arry.Length; i++)
            {
                if(i>0)
                    Write(" , ");

                Write(arry[i]);
                sum += arry[i];
            }
            WriteLine();

            return sum;
        }
    }
}
