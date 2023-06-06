using ConsoleApp1.Interface;
using FakeItEasy;
using System;
using FluentAssertions;
using Moq;
using Xunit;

namespace ConsoleApp1.Tests
{
    public class CalculatorTest
    {
        public Mock<ICalculatorLogger> logger { get; set; }

        public CalculatorTest()
        {
            logger = new Mock<ICalculatorLogger>();
        }
        
        [Fact]
        public void Divide_ShouldWorkWith()
        {
            // arrange
            var service = new Calculator(logger.Object);
            var expected = 2.5;

            // act
            var actual = service.Divide(5, 2);

            // assert
            actual.Result.Should().Be(expected);
            actual.Issues.Should().BeEmpty();
            actual.Status.Should().BeTrue();

            // TODO: Fazer funcionar
            // logger.Object.Issues.Should().HaveCount(2);
        }
        
        [Fact]
        public void Divide_ShouldFail()
        {
            // arrange
            var service = new Calculator(logger.Object);

            // act
            var actual = service.Divide(5, 0);

            // assert
            actual.Result.Should().Be(0);
            actual.Issues.Should().HaveCountGreaterThan(0);
            actual.Status.Should().BeFalse();
            
            // TODO: Fazer funcionar
            // logger.Object.Issues.Should().HaveCount(3);
        }
    }
}
