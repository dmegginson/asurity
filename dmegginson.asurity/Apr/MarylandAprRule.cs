using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Apr
{
    public class MarylandAprRule : BaseAprRule
    {
        public MarylandAprRule() : base(States.Maryland)
        {
        }

        public override bool Pass(ILoan loan)
        {
            bool pass = false;

            if (loan.State == State)
            {
                pass = loan.APR < 4.0;
            }

            return pass;
        }
    }
}
