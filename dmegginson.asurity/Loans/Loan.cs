using System;
using System.Collections.Generic;
using dmegginson.asurity.Fee;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Loans
{
    public class Loan : ILoan
    {
        public Loan()
        {
        }

        public long Amount { get; set; }

        public States State { get; set; }

        public double APR { get; set; }

        public bool IsPrimaryOccupancy { get; set; }

        public LoanType Type { get; set; }

        public Dictionary<FeeType, double> Fees { get; set; }
    }
}
