using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideAbstract_Methods
{
    public abstract class Expression
    {
        //An abstract method is a virtual method with no implementation.
        //An abstract method is declared with the abstract modifier and is permitted only in an abstract class.
        //An abstract method must be overridden in every non-abstract derived class.
        public abstract double Evaluate(Dictionary<string, object> vars);
        public void RandomMethod()
        {
            var x = 0;
            x += 1;
        }
    }


    public class Constant : Expression
    {
        double _value;

        public Constant(double value)
        {
            _value = value;
        }

        public override double Evaluate(Dictionary<string, object> vars)
        {
            return _value;
        }

        //A virtual method can be overridden in a derived class.
        //When an instance method declaration includes an override modifier,
        //  the method overrides an inherited virtual method with the same signature.
        //A virtual method declaration introduces a new method.
        //An override method declaration specializes an existing inherited virtual method by
        //  providing a new implementation of that method.
        public virtual void RandomMethod2()
        {
            var randomVariable = 0;
            randomVariable += 1;
        }
    }

    public class VariableReference : Expression
    {
        string _name;

        public VariableReference(string name)
        {
            _name = name;
        }

        public override double Evaluate(Dictionary<string, object> vars)
        {
            object value = vars[_name] ?? throw new Exception($"Unknown variable: {_name}");
            return Convert.ToDouble(value);
        }
    }

    public class Operation : Expression
    {
        Expression _left;
        char _op;
        Expression _right;

        public Operation(Expression left, char op, Expression right)
        {
            _left = left;
            _op = op;
            _right = right;
        }

        public override double Evaluate(Dictionary<string, object> vars)
        {
            double x = _left.Evaluate(vars);
            double y = _right.Evaluate(vars);
            switch (_op)
            {
                case '+': return x + y;
                case '-': return x - y;
                case '*': return x * y;
                case '/': return x / y;

                default: throw new Exception("Unknown operator");
            }
        }
    }
}
