using System;
using interpreter.models;

namespace interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            // arrange props
            int x = 5;
            int y = 8;
            int z = 2;
            int d = 5;
            
            // add props to context
            context.SetVariable("x", x);
            context.SetVariable("y", y);
            context.SetVariable("z", z);
            context.SetVariable("d", d);
            // create an object to evaluate the expression x + y - z
            IExpression expression = new SubtractExpression(
                new AddExpression(
                    new ValueExpression("x"), new ValueExpression("y")
                ),
                new ValueExpression("z")
            );
    
            int result = expression.Interpret(context);
            context.SetVariable("result", result);
            Console.WriteLine("Result of x + y - z : {0}", result);

            expression = new MultiplicationExpression(
                new ValueExpression("result"),
                new ValueExpression("d")
            );
            result = expression.Interpret(context);
            Console.WriteLine("Result of (x + y - z)*d : {0}", result);
            Console.Read();
        }
    }
}
