using System.Net;
using FluentAssertions;
using Newtonsoft.Json;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Inventory.Tests.E2E.Steps
{
    [Binding]
    public class InventoryManagementSteps
    {


        [Given(@"I Want To Add The Following Inventory")]
        public void GivenIWantToAddTheFollowingInventory(Table table)
        {

        }

        [When(@"I Try To Define This Inventory")]
        public void WhenITryToDefineThisInventory()
        {
        }

        [Then(@"The Inventory Should Be Created")]
        public void ThenTheInventoryShouldBeCreated()
        {

        }

        [Then(@"It Should Be Empty")]
        public void ThenItShouldBeEmpty()
        {
        }
    }
}