using Xunit;
using DemoCICD_QOTD.Controllers;
using System.Collections;

using Microsoft.AspNetCore.Mvc;
namespace Demo_CIDC_QOTD.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            //ACT 
       
            QuoteoftheDayController obj = new QuoteoftheDayController();
            IEnumerable  actualtResult = obj.Get();
            

            //ASSERT
            Assert.True(actualtResult.Equals("Not the quote it should be"), "This was not the quote it has selected");

        }

    }

}