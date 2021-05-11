using dmegginson.asurity.Fee;
using dmegginson.asurity.Global;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Rules
{
    public class FloridaStateRuleEngine : BaseStateRuleEngine
    {
        public FloridaStateRuleEngine() : base(States.Florida, new FloridaGlobalRule(), new FloridaFeeRule())
        {
        }
    }
}
