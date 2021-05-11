using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Global
{
    public class CaliforniaGlobalRule : BaseGlobalRule
    {
        public CaliforniaGlobalRule() : base(States.California)
        {
        }

        public override bool Pass(ILoan loan)
        {
            bool pass = false;

            if(loan.State == State)
            {
                if (loan.Amount <= 600000)
                {
                    pass = true;
                }
            }

            return pass;
        }
    }
}