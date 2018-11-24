using System;

namespace exp4net.function
{
    public class Functions
    {
        public static Function GetBuildFunction(string name)
        {
            switch (name)
            {
                case FunctionNames.Sin:
                    return new Function(FunctionNames.Sin)
                    {
                        Apply = (double[] args) => Math.Sin(args[0])
                    };
                case FunctionNames.Cos:
                    return new Function(FunctionNames.Cos)
                    {
                        Apply = (double[] args) => Math.Cos(args[0])
                    };
                case FunctionNames.Tan:
                    return new Function(FunctionNames.Tan)
                    {
                        Apply = (double[] args) => Math.Tan(args[0])
                    };
                case FunctionNames.Cot:
                    return new Function(FunctionNames.Cot)
                    {
                        Apply = (double[] args) =>
                        {
                            double tan = Math.Tan(args[0]);
                            if (tan != 0)
                            {
                                return 1d / Math.Tan(args[0]);
                            }

                            throw new ArithmeticException("Division by zero in cotangent!");
                        }
                    };
                case FunctionNames.Log:
                    return new Function(FunctionNames.Log)
                    {
                        Apply = (double[] args) => Math.Log(args[0])
                    };
                case FunctionNames.Log2:
                    return new Function(FunctionNames.Log2)
                    {
                        Apply = (double[] args) => Math.Log(args[0], 2)
                    };
                case FunctionNames.Log10:
                    return new Function(FunctionNames.Log10)
                    {
                        Apply = (double[] args) => Math.Log10(args[0])
                    };
                default:
                    return null;
            }
        }
    }
}