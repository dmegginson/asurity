using System.Collections.Generic;
using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Rules
{
    public interface IStateRuleEngine
    {
        States State { get; }

        IRule GlobalRule { get; }

        List<IRule> Rules { get; }

        LoanValidationResponse ValidateLoan(ILoan loan);
    }
}
