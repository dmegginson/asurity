using System;
using System.Collections.Generic;
using dmegginson.asurity.Rules;

namespace dmegginson.asurity.Loans
{
    public class LoanValidationResponse
    {
        public LoanValidationResponse()
        {
            Results = new List<RuleTestResult>();
        }

        public List<RuleTestResult> Results { get; private set; }
    }
}
