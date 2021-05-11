using dmegginson.asurity.Apr;
using dmegginson.asurity.Fee;
using dmegginson.asurity.Global;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Rules
{
    public class CaliforniaStateRuleEngine : BaseStateRuleEngine
    {
        public CaliforniaStateRuleEngine() : base(States.California, new CaliforniaGlobalRule(), new CaliforniaAprRule(), new CaliforniaFeeRule())
        {
        }
    }
}
