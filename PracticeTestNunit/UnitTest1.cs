using NUnit;
using NUnit.Framework;
using System;
using PractiseTests;

namespace PracticeTestNunit
{
    [TestFixture]
    public class UnitTest1
    {
        StringOperations obj;
        [SetUp]
        public void Init()
        {
            obj = new StringOperations();
        }
        [TestCase("Ram","Das","Das , Ram")]
        public void StringOperationso_onBothNames_ReturnFullName(string fname,string lname,string ExpectedResult)
        {
            //StringOperations obj = new StringOperations();
            var result=obj.Concat("ram","das");            
            Assert.That(ExpectedResult, Is.EqualTo(result));
        }
   
        [TestCase(null,"hi")]
        public void StringOperations_onFirstNameNull_throwsException(string fname, string lname)
        {
            var x=Assert.Throws<ArgumentNullException>(() => obj.Concat(fname,lname));
            Assert.That(x.Message, Is.EqualTo($"Value cannot be null.\r\nParameter name: firstname"));
        }
   
        [TestCase("hi",null)]
        public void StringOperations_onLastNameNull_throwsException(string fname, string lname)
        {
            var x = Assert.Throws<ArgumentNullException>(() => obj.Concat(fname, lname));
            Assert.That(x.Message, Is.EqualTo($"Value cannot be null.\r\nParameter name: lastname"));
        }
    }
}

