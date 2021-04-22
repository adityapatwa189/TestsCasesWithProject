//using NUnit;
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
        [Test]
        public void StringOperationso_onBothNames_ReturnFullName()
        {
            //StringOperations obj = new StringOperations();
            var result=obj.Concat("ram","das");
            var lastname = "das";
            var firstname = "ram";
            var ans = $"{lastname} , {firstname}";
            Assert.That("das , ram", Is.EqualTo(result));
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

