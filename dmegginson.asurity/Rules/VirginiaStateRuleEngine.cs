using dmegginson.asurity.Apr;
using dmegginson.asurity.Fee;
using dmegginson.asurity.Global;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Rules
{
    public class VirginiaStateRuleEngine : BaseStateRuleEngine
    {
        public VirginiaStateRuleEngine() : base(States.Virginia, new VirginiaGlobalRule(), new VirginiaAprRule(), new VirginiaFeeRule())
        {
        }
    }
}
