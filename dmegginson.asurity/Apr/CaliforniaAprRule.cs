using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Apr
{
    public class CaliforniaAprRule : BaseAprRule
    {
        public CaliforniaAprRule() : base(States.California)
        {
        }

        public override bool Pass(ILoan loan)
        {
            bool pass = false;

            if(loan.State == State)
            {
                if (loan.IsPrimaryOccupancy && (loan.Type == LoanType.Conventional || loan.Type == LoanType.FHA))
                {
                    pass = loan.APR < 5.0;
                }
                else if (!loan.IsPrimaryOccupancy)
                {
                    pass = loan.APR < 4.0;
                }
                else if (loan.Type == LoanType.VA)
                {
                    pass = loan.APR < 3.0;
                }
            }

            return pass;
        }
    }
}
