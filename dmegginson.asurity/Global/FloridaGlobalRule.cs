using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Global
{
    public class FloridaGlobalRule : BaseGlobalRule
    {
        public FloridaGlobalRule() : base(States.Florida)
        {
        }

        public override bool Pass(ILoan loan)
        {
            bool pass = false;

            if (loan.State == State)
            {
                if (loan.Type == LoanType.Conventional || loan.Type == LoanType.VA)
                {
                    pass = true;
                }
            }

            return pass;
        }
    }
}