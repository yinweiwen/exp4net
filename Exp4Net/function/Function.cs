using System;
using System.Text.RegularExpressions;

namespace exp4net.function
{
    public class Function
    {
        protected readonly string name;
        protected readonly int argsCount;


        public Function(string name, int argsCount)
        {
            if (argsCount < 0)
            {
                throw new ArgumentException(
                    string.Format("The number of function arguments can not be less than 0 for {0}", name));
            }

            if (!IsValidFunctionName(name))
            {
                throw new ArgumentException(String.Format("The function name {0} is invalid", name));
            }

            this.name = name;
            this.argsCount = argsCount;
        }

        public Function(string name) : this(name, 1)
        {
        }


        public string Name
        {
            get { return this.name; }
        }

        public int ArgsCount
        {
            get { return this.argsCount; }
        }

        public Func<double[], double> Apply { get; set; }

        public static bool IsValidFunctionName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                return false;
            }

            string RegexStr = "^[a-zA-Z_]\\w*$";
            if (Regex.IsMatch(name, RegexStr))
            {
                return true;
            }

            return false;
        }
    }
}