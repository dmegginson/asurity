using System;
using dmegginson.asurity.Loans;
using dmegginson.asurity.Rules;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Apr
{
    public abstract class BaseAprRule : BaseRule
    {
        protected BaseAprRule(States state) : base(RuleType.APR, state)
        {
        }
    }
}
