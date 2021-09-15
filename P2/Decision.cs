using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    public enum DecisionType
    {
        Cancel,
        Throw,
        Keep
    }

    class Decision
    {
        private DecisionType type;
        public Decision(string choice)
        {
            type = ParseChoice(choice);
        }

        private static DecisionType ParseChoice(string choice)
        {
            return (DecisionType)Enum.Parse(typeof(DecisionType), choice);
        }

        public string GetOutput()
        {
            string result = null;
            switch (type)
            {
                case DecisionType.Cancel:
                    result = "cancel.";
                    break;
                case DecisionType.Throw:
                    result = "is to throw it back.";
                    break;
                case DecisionType.Keep:
                    result = "is to keep it.";
                    break;
            }
            return result;
        }
    }
}
