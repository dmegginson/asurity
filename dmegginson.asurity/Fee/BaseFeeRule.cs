using System;
using System.Collections.Generic;
using dmegginson.asurity.Loans;
using dmegginson.asurity.Rules;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Fee
{
    public abstract class BaseFeeRule : BaseRule
    {
        protected BaseFeeRule(States state) : base(RuleType.Fee, state)
        {
        }

        protected double CalculateTotalFees(Dictionary<FeeType, double> fees, params FeeType[] feeTypes)
        {
            var totalFees = 0.0;
            foreach (var feeType in feeTypes)
            {
                totalFees += fees.ContainsKey(feeType) ? fees[feeType] : 0;
            }

            return totalFees;
        }
    }
}
