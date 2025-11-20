using Xunit;
using TestProject1;
using ConsoleApp1;
namespace TestProject1
{
    public class GeometryServiceTest
    {
        private readonly GeometryService _service = new GeometryService();

     

       
        [Fact]
        public void TriangleArea_ReturnsCorrectValue()
        {
            double result = _service.TriangleArea(10, 5);

            Xunit.Assert.Equal(25, result);                         
            Xunit.Assert.True(result > 0);                          
            Xunit.Assert.InRange(result, 20, 30);                  
        }

       
        [Xunit.Theory]
        [InlineData(3, 4, 5)]
        [InlineData(5, 12, 13)]
        [InlineData(6, 8, 10)]
        public void RectangleDiagonal_InlineData(double a, double b, double expected)
        {
            double result = _service.RectangleDiagonal(a, b);

            Xunit.Assert.Equal(expected, result, 3);               
        }

      
        [Xunit.Theory]
        [MemberData(nameof(MemberData.Data),
            MemberType = typeof(MemberData))]
        public void RectangleDiagonal_MemberData(double a, double b, double expected)
        {
            double result = _service.RectangleDiagonal(a, b);

            Xunit.Assert.Equal(expected, result, 3);
        }

       
        [Xunit.Theory]
        [ClassData(typeof(TriangleArea))]
        public void TriangleArea_ClassData(double a, double h, double expected)
        {
            double result = _service.TriangleArea(a, h);
            var service2 = _service;
            Xunit.Assert.Same(_service, service2);                
            Xunit.Assert.NotSame(_service, new GeometryService());
        }

        
        [Fact]
        public void TriangleArea_Throws_OnNegativeValues()
        {
            Xunit.Assert.Throws<ArgumentException>(() => _service.TriangleArea(-3, 5));
        }

        
        [Fact]
        public void RectangleDiagonal_ExceptionMessage()
        {
            var ex = Assert.Throws<ArgumentException>(() => _service.RectangleDiagonal(0, 5));

            Xunit.Assert.Contains("додатними", ex.Message);        
        }

       
        [Fact]
        public void Service_Instance_ReferenceTest()
        {
            var service2 = _service;

            Xunit.Assert.Same(_service, service2);                 
            Xunit.Assert.NotSame(_service, new GeometryService());
        }
    }
}