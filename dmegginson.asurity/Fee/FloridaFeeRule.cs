using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Fee
{
    public class FloridaFeeRule : BaseFeeRule
    {
        public FloridaFeeRule() : base(States.Florida)
        {
        }

        public override bool Pass(ILoan loan)
        {
            bool pass = false;

            if (loan.State == State)
            {
                if (loan.Amount <= 20000)
                {
                    pass = CalculateTotalFees(loan.Fees, FeeType.Application, FeeType.Settlement) / loan.Amount <= .06;
                }
                else if (loan.Amount > 20000 && loan.Amount <= 75000)
                {
                    pass = CalculateTotalFees(loan.Fees, FeeType.Application, FeeType.Settlement) / loan.Amount <= .08;
                }
                else if (loan.Amount > 75000 && loan.Amount <= 150000)
                {
                    pass = CalculateTotalFees(loan.Fees, FeeType.Application, FeeType.Settlement) / loan.Amount <= .09;
                }
                else if (loan.Amount > 150000)
                {
                    pass = CalculateTotalFees(loan.Fees, FeeType.Application, FeeType.Settlement) / loan.Amount <= .10;
                }
            }

            return pass;
        }
    }
}
