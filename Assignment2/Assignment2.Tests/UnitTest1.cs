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

        [Fact]
        public void ImmutableStudent_equal()
        {
            //Arrange
            ImmutableStudent Jens1 = new ImmutableStudent(1, "Jens", "Jensen", Status.New);
            ImmutableStudent Jens2 = new ImmutableStudent(1, "Jens", "Jensen", Status.New);
            
            //Act
            var output = Jens1 == Jens2;

            //Assert
            Assert.True(output);


        }

        [Fact]
        public void ImmutableStudent_toString()
        {
            //Arrange
            ImmutableStudent Jens1 = new ImmutableStudent(1, "Jens", "Jensen", Status.New);
            var expected = "ImmutableStudent { GivenName = Jens, status = New }";
            
            //Act
            var output = Jens1.ToString();

            //Assert
            Assert.Equal(expected,output);


        }
    }
}
