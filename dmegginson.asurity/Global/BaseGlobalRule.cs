using System;
using dmegginson.asurity.Loans;
using dmegginson.asurity.Rules;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Global
{
    public abstract class BaseGlobalRule : BaseRule, IGlobalRule
    {
        protected BaseGlobalRule(States state) : base(RuleType.Global, state)
        {
        }
    }
}
