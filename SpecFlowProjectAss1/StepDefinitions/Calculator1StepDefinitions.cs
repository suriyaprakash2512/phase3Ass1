
using CalAssLib;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectAss1.StepDefinitions
{
    [Binding]
    public sealed class Calculator1StepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Calculator calculator;
        private int result;
        public Calculator1StepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.calculator = new Calculator();
        }
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calculator.Fnum = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calculator.Snum = number;
        }
        [When(@"the two numbers are subtract")]
        public void WhenTheTwoNumbersAreSubtract()
        {
            result = calculator.Sub();
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = calculator.Multi();
        }


        [When(@"the two numbers are Divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = calculator.Div();
        }
        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            result.Should().Be(result);
        }
    }
}