using dmegginson.asurity.Apr;
using dmegginson.asurity.Fee;
using dmegginson.asurity.Global;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Rules
{
    public class MarylandStateRuleEngine : BaseStateRuleEngine
    {
        public MarylandStateRuleEngine() : base(States.Maryland, new MarylandGlobalRule(), new MarylandAprRule(), new MarylandFeeRule())
        {
        }
    }
}
