using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Fee
{
    public class CaliforniaFeeRule : BaseFeeRule
    {
        public CaliforniaFeeRule() : base(States.California)
        {
        }

        public override bool Pass(ILoan loan)
        {
            bool pass = false;

            if(loan.State == State)
            {
                if (loan.Amount <= 50000)
                {
                    pass = CalculateTotalFees(loan.Fees, FeeType.Application, FeeType.Settlement) / loan.Amount <= .03;
                }
                else if (loan.Amount > 50000 && loan.Amount <= 150000)
                {
                    pass = CalculateTotalFees(loan.Fees, FeeType.Application, FeeType.Settlement) / loan.Amount <= .04;
                }
                else if (loan.Amount > 150000)
                {
                    pass = CalculateTotalFees(loan.Fees, FeeType.Application, FeeType.Settlement) / loan.Amount <= .05;
                }
            }

            return pass;
        }
    }
}
