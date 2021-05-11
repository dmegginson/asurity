using System;
using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Rules
{
    public abstract class BaseRule : IRule
    {
        protected BaseRule(RuleType type, States state)
        {
            Type = type;
            State = state;
        }

        public States State { get; private set; }

        public RuleType Type { get; private set; }

        public abstract bool Pass(ILoan loan);
    }
}
