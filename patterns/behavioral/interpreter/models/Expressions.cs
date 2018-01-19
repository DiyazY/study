
using System;
using System.Collections.Generic;

namespace interpreter.models
{
    public interface IExpression
    {
        int Interpret(Context context);
    }

    // context
    public class Context
    {
        Dictionary<string, int> variables;
        public Context()
        {
            variables = new Dictionary<string, int>();
        }
        public int GetVariable(string name)
        {
            return variables[name];
        }
    
        public void SetVariable(string name, int value)
        {
            if (variables.ContainsKey(name))
                variables[name] = value;
            else
                variables.Add(name, value);
        }
    }

    // terminal expression
    class ValueExpression : IExpression
    {
        string name; // prop name
        public ValueExpression(string variableName)
        {
            name = variableName;
        }
        public int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }

    // nonterminal expression for addition
    class AddExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;
    
        public AddExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }
    
        public int Interpret(Context context)
        {
            return leftExpression.Interpret(context) + rightExpression.Interpret(context);
        }
    }
    // nonterminal expression for subtraction
    class SubtractExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;
    
        public SubtractExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }
    
        public int Interpret(Context context)
        {
            return leftExpression.Interpret(context) - rightExpression.Interpret(context);
        }
    }

    // nonterminal expression for multiplication
    class MultiplicationExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;
    
        public MultiplicationExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }
    
        public int Interpret(Context context)
        {
            return leftExpression.Interpret(context) * rightExpression.Interpret(context);
        }
    }
}
