using System;
using Xunit;
using src;
namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var name=new Student();
            name.add(23.5);
            name.add(54.3);
            name.add(22.5);

          //  var Tresult=name.Getstatistics();
    
    //action
    var Tresult=name.Getstatistics();
    //assert
    Assert.Equal(54.3,Tresult.High);
        }
    }
}
