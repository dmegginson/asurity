using System;
namespace dmegginson.asurity.Rules
{
    public class RuleTestResult
    {
        public RuleTestResult(string ruleName, bool pass)
        {
            RuleName = ruleName;
            Pass = pass;
        }

        public string RuleName { get; private set; }

        public bool Pass { get; private set; }
    }
}
