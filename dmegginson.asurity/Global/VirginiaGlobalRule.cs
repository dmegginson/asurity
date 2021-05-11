using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Global
{
    public class VirginiaGlobalRule : BaseGlobalRule
    {
        public VirginiaGlobalRule() : base(States.Virginia)
        {
        }

        public override bool Pass(ILoan loan)
        {
            bool pass = false;

            if (loan.State == State)
            {
                pass = true;
            }

            return pass;
        }
    }
}