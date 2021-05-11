using System.Collections.Generic;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Rules
{
    public class RulesEngineFactory : IRulesEngineFactory
    {
        public RulesEngineFactory()
        {
            StateRuleEngines = new Dictionary<States, IStateRuleEngine>()
            {
                { States.California, new CaliforniaStateRuleEngine() },
                { States.Florida, new FloridaStateRuleEngine() },
                { States.Maryland, new MarylandStateRuleEngine() },
                { States.NewYork, new NewYorkStateRuleEngine() },
                { States.Virginia, new VirginiaStateRuleEngine() },
            };            
        }

        private Dictionary<States, IStateRuleEngine> StateRuleEngines { get; set; }

        public IStateRuleEngine GetStateRuleEngine(States state)
        {
            return StateRuleEngines.ContainsKey(state) ? StateRuleEngines[state] : null;
        }
    }
}
