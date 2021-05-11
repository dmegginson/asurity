using dmegginson.asurity.Apr;
using dmegginson.asurity.Loans;
using dmegginson.asurity.State;
using FluentAssertions;
using NUnit.Framework;

namespace dmegginson.asurity.test
{
    public class CaliforniaAprRuleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void State_Should_Equal_California()
        {
            // Arrange
            var sut = new CaliforniaAprRule();

            // Act

            // Assert
            sut.State.Should().Be(States.California);
        }

        [Test]
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

        [Test]
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