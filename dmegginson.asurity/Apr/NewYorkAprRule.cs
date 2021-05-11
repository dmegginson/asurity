using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Apr
{
    public class NewYorkAprRule : BaseAprRule
    {
        public NewYorkAprRule() : base(States.NewYork)
        {
        }

        public override bool Pass(ILoan loan)
        {
            bool pass = false;

            if (loan.State == State)
            {
                if (loan.Type == LoanType.Conventional)
                {
                    if (loan.IsPrimaryOccupancy)
                    {
                        pass = loan.APR < 6.0;
                    }
                    else
                    {
                        pass = loan.APR < 8.0;
                    }
                }
            }

            return pass;
        }
    }
}
