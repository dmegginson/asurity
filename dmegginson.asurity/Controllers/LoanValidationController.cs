using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dmegginson.asurity.Fee;
using dmegginson.asurity.Loans;
using dmegginson.asurity.Rules;
using dmegginson.asurity.State;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dmegginson.asurity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanValidationController : ControllerBase
    {
        private readonly ILogger<LoanValidationController> logger;

        private readonly IRulesEngineFactory rulesEngineFactory;

        public LoanValidationController(ILogger<LoanValidationController> logger, IRulesEngineFactory rulesEngineFactory )
        {
            this.logger = logger;
            this.rulesEngineFactory = rulesEngineFactory;
        }

        [HttpPost]
        public LoanValidationResponse ValidateLoan(Loan loan)
        {
            return this.rulesEngineFactory.GetStateRuleEngine(loan.State)?.ValidateLoan(loan);
        }        
    }
}