using EAAutoFramework.Base;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CrossPlatformEATest.Steps
{
    [Binding]
    public class CalculatorSteps : BaseStep
    {
        //Context injection
        private readonly ParallelConfig _parallelConfig;

        public CalculatorSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }
        private int FirstNumber { get; set; }
        private int SecondNumber { get; set; }
        private int _result;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int firsrNumber)
        {
            FirstNumber = firsrNumber;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int secondNumber)
        {
            SecondNumber = secondNumber;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = FirstNumber + SecondNumber;  
        }

        [When(@"the two numbers are rested")]
        public void WhenTheTwoNumbersAreRested()
        {
            _result = FirstNumber - SecondNumber;
        }


        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.That(_result, Is.EqualTo(result));

        }
    }
}
