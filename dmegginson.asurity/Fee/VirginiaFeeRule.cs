using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Fee
{
    public class VirginiaFeeRule : BaseFeeRule
    {
        public VirginiaFeeRule() : base(States.Virginia)
        {
        }

        public override bool Pass(ILoan loan)
        {
            bool pass = false;

            if (loan.State == State)
            {
                pass = CalculateTotalFees(loan.Fees, FeeType.FloodCertification, FeeType.Processing, FeeType.Settlement) / loan.Amount <= .07;
            }

            return pass;
        }
    }
}