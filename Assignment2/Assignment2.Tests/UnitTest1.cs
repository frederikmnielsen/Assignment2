using System;
using Xunit;

namespace Assignment2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void toString_returns_1_john_andersen()
        {
            //Arrange
            var john = new Student(1, "john", "andersen");
            
            //Act
            var output = john.ToString();

            //Assert
            Assert.Equal("1 john andersen", output);


        }

        [Fact]
        public void new_student_has_status_new()
        {
            //Arrange
            var john = new Student(1, "john", "andersen");
            
            //Act
            var output = john.status;

            //Assert
            Assert.Equal(Status.New, output);


        }
    }
}
