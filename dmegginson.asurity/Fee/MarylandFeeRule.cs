using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Fee
{
    public class MarylandFeeRule : BaseFeeRule
    {
        public MarylandFeeRule() : base(States.Maryland)
        {
        }

        public override bool Pass(ILoan loan)
        {
            bool pass = false;

            if (loan.State == State)
            {
                if (loan.Amount <= 200000)
                {
                    pass = CalculateTotalFees(loan.Fees, FeeType.Application, FeeType.CreditReport) / loan.Amount <= .04;
                }
                else if (loan.Amount > 200000)
                {
                    pass = CalculateTotalFees(loan.Fees, FeeType.Application, FeeType.CreditReport) / loan.Amount <= .06;
                }
            }

            return pass;
        }
    }
}