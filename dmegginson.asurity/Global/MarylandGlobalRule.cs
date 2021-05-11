using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Global
{
    public class MarylandGlobalRule : BaseGlobalRule
    {
        public MarylandGlobalRule() : base(States.Maryland)
        {
        }

        public override bool Pass(ILoan loan)
        {
            bool pass = false;

            if (loan.State == State)
            {
                if (loan.Amount <= 400000)
                {
                    pass = true;
                }
            }

            return pass;
        }
    }
}