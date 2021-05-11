using Microsoft.VisualStudio.TestTools.UnitTesting;
using dmegginson.asurity.Apr;
using dmegginson.asurity.Loans;
using dmegginson.asurity.State;
using FluentAssertions;

namespace dmegginson.asurity.test
{
    [TestClass]
    public class CaliforniaAprRuleTests
    {
        [TestMethod]
        public void State_Should_Equal_California()
        {
            // Arrange
            var sut = new CaliforniaAprRule();

            // Act

            // Assert
            sut.State.Should().Be(States.California);
        }

        [TestMethod]
        public void Pass_Should_Return_True()
        {
            // Arrange
            var loan = new Loan()
            {
                State = States.California,
                Type = LoanType.Conventional,
                APR = 3.5,
                IsPrimaryOccupancy = true
            };

            var sut = new CaliforniaAprRule();

            // Act
            bool result = sut.Pass(loan);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void Pass_Should_Return_False_Apr_Too_Large()
        {
            // Arrange
            var loan = new Loan()
            {
                State = States.California,
                Type = LoanType.Conventional,
                APR = 5.5,
                IsPrimaryOccupancy = true
            };

            var sut = new CaliforniaAprRule();

            // Act
            bool result = sut.Pass(loan);

            // Assert
            result.Should().BeFalse();
        }
    }
}
