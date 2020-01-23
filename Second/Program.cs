using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second
{
    class Program
    {

        public static readonly string address = Constants.address;
        public static readonly string format = Constants.format;
        private static string DummyFunc()
        {
            return String.Format(format, "Петя", "школьный друг", address, 30);
        }

        private static string DummyFuncAgain()
        {
            return String.Format(format, "Вася", "сосед", address, 54);
        }

        private static string DummyFuncMore()
        {
            return String.Format(format, "Николай", "сын", address, 4);
        }

        private static void MakeFunc(Func<string> func, Action<string> output)
        {
            string methodName = func.Method.Name;
            output(String.Format("Начало работы метода {0}", methodName));
            output(func());
            output(String.Format("Окончание работы метода {0}", methodName));
        }

        private static void MakeFuncForm(Func<string> func)
        {
            string methodName = func.Method.Name;
            Console.WriteLine("Начало работы метода {0}", methodName);
            MessageBox.Show(func());
            Console.WriteLine("Окончание работы метода {0}", methodName);
        }

        private static IEnumerable<Func<string>> GetActionSteps()
        {
            return new List<Func<string>>()
            {
                DummyFunc
                , DummyFuncAgain
                , DummyFuncMore
            };
        }
        static void Main(string[] args)
        {
            IEnumerable<Func<string>> funcs = GetActionSteps();
            foreach (Func<string> func in funcs)
            {
                MakeFunc(func, Console.WriteLine);
            }
            Console.ReadLine();
        }
    }
}
