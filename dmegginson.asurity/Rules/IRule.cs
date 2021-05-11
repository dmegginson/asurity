using System;
using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Rules
{
    public interface IRule
    {
        RuleType Type { get; }

        States State { get; }

        bool Pass(ILoan loan);
    }
}
