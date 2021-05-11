using System.Collections.Generic;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Rules
{
    public interface IRulesEngineFactory
    {
        IStateRuleEngine GetStateRuleEngine(States state);
    }
}
