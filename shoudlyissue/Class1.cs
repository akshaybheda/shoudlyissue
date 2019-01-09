using Shouldly;

namespace COVERLETISSUE
    {
    public class Class1
        {
        public void TestSubject (string data)
            {
            data.ShouldNotBeNull("This should not be null");
            }
        }
    }
