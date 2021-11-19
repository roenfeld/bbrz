using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaschenRechnerOOP
{
  class Calculator
  {
    public enum Operators
    {
      None,
      Add, Sub, Mul, Div
    }


    public decimal Value1 { get; set; }
    public decimal Value2 { get; set; }

    public Operators Operator { get; set; } = Operators.None;

    public decimal Result
    {
      get
      {
        switch(this.Operator)
        {
          case Operators.None:
            return 0;
          case Operators.Add:
            return Value1 + Value2;
          case Operators.Sub:
            return Value1 - Value2;
          case Operators.Mul:
            return Value1 * Value2;
          case Operators.Div:
            return Value1 / Value2;
        }

        return 0;
      }
    }

  }
}
