using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Apr
{
    public class VirginiaAprRule : BaseAprRule
    {
        public VirginiaAprRule() : base(States.Virginia)
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
                        pass = loan.APR < 5.0;
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
