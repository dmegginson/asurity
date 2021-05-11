using dmegginson.asurity.Apr;
using dmegginson.asurity.Fee;
using dmegginson.asurity.Global;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Rules
{
    public class NewYorkStateRuleEngine : BaseStateRuleEngine
    {
        public NewYorkStateRuleEngine() : base(States.NewYork, new NewYorkGlobalRule(), new NewYorkAprRule())
        {
        }
    }
}
