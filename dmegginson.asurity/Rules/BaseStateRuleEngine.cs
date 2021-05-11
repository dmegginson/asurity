using System.Collections.Generic;
using dmegginson.asurity.Global;
using dmegginson.asurity.Loans;
using dmegginson.asurity.State;

namespace dmegginson.asurity.Rules
{
    public abstract class BaseStateRuleEngine : IStateRuleEngine
    {
        protected BaseStateRuleEngine(States state, IGlobalRule globalRule, params IRule [] rules)
        {
            State = state;
            GlobalRule = globalRule;
            Rules = new List<IRule>(rules);
        }

        public States State { get; private set; }

        public IRule GlobalRule { get; private set; }

        public List<IRule> Rules { get; private set; }

        public LoanValidationResponse ValidateLoan(ILoan loan)
        {
            var response = new LoanValidationResponse();

            var globalRuleResult = CreateRuleTestResult(GlobalRule.Type, GlobalRule.Pass(loan));
            response.Results.Add(globalRuleResult);

            if (globalRuleResult.Pass)
            {
                RunRuleTests(loan, response);
            }

            return response;
        }

        protected void RunRuleTests(ILoan loan, LoanValidationResponse response)
        {
            foreach (var rule in Rules)
            {
                response.Results.Add(CreateRuleTestResult(rule.Type, rule.Pass(loan)));
            }
        }

        protected RuleTestResult CreateRuleTestResult(RuleType ruleType, bool result)
        {
            return new RuleTestResult(ruleType.ToString(), result);
        }
    }
}
