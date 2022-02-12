using InterfaceTest;

namespace ClassTest
{
    public class ClassA
    {
    }
    public class ClassB : ClassA
    {
    }
    public class ClassC
    {
        ClassA a = new ClassA();
        ClassB b = new ClassB();
        ClassA c = new ClassB();
        //ClassB d = new ClassA();  // 자식 클래스가 부모 클래스의 생성자로 초기화될 수 없음
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            WriteLine($"{DateTime.Now.ToString()} - {message}");
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine($"{DateTime.Now.ToString()} - {message}");
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Write("온도를 입력해 주세요 >> ");
                string temperature = ReadLine();
                if (double.TryParse(temperature, out double out_i))
                    logger.WriteLog("현재 온도 : " + out_i + "℃");
                else if (temperature == "")
                    break;
                else
                    WriteLine("Error! 숫자를 입력해 주세요\n");
            }
        }
    }
}
