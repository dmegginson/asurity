using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Global
{
    public class NewYorkGlobalRule : BaseGlobalRule
    {
        public NewYorkGlobalRule() : base(States.NewYork)
        {
        }

        public override bool Pass(ILoan loan)
        {
            bool pass = false;

            if (loan.State == State)
            {
                if (loan.Type == LoanType.Conventional && loan.Amount <= 750000)
                {
                    pass = true;
                }
            }

            return pass;
        }
    }
}