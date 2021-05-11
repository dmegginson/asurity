using System;
using System.Collections.Generic;
using dmegginson.asurity.Fee;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Loans
{
    public interface ILoan
    {
        long Amount { get; }

        States State { get; }

        double APR { get; set; }

        bool IsPrimaryOccupancy { get; set; }

        LoanType Type { get; }

        Dictionary<FeeType, double> Fees { get; }
    }
}
