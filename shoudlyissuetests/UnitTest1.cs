using System;
using COVERLETISSUE;
using Shouldly;
using Xunit;

namespace Coverletissuetests
    {
    public class UnitTest1
        {
        [Fact]
        public void Test1 ()
            {
            Class1 clsobj = new Class1 ();
            Should.Throw<ShouldAssertException> (() => clsobj.TestSubject (null)).Message.ShouldBe("data\n    should not be null but was\n\nAdditional Info:\n    This should not be null");
            }
        }
    }
