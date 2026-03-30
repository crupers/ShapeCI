using ShapeCi;
namespace ShapeTestCi
{
    public class ShapeTestCi1
    {
        [Fact]
        public void CreateShapeRectangel_Test1()
        {
            Rectangle rec = new Rectangle();
            rec.Width = 10;
            rec.Height = 10;
      
            Assert.Equal(100, rec.Area());
        }
       
        [Fact]
        public void ShapeRectangleCorrect_TestPerimetr()
        {            
            Rectangle rec = new Rectangle();
            rec.Width = 4;
            rec.Height = 5;
            double result = 18;
            double PerimRez = rec.Perimeter();
            Assert.Equal(result, PerimRez);
        }
        [Fact]
        public void ShapeRectangleCorrect_TestPerimetr3()
        {
            Rectangle rec = new Rectangle();
            rec.Height = 5;
            Assert.Throws<ArgumentException>(() => rec.Width = 0);
        }
        [Fact]
        public void ShapeRectangleCorrect_TestPerimetr4()
        {
            Rectangle rec = new Rectangle();
            rec.Height = 5;
            Assert.Throws<ArgumentException>(() => rec.Width = -120);
        }
        /* [Fact]
         public void RectanglFailedFatal_Test()
         {
            Rectangle rec = new Rectangle();
             rec.Width = 4;
             rec.Height= 5;
             double FatalResult = 100;
             double Arearez = rec.Area(); 
             Assert.Equal(FatalResult, Arearez);

         }*/
        [Theory]
        [InlineData(3,4,5)]
        public void Triangle_Area_ShouldReturnCorrectValue(double a,double b,double c)
        {

            Triangle tr = new Triangle();     
            tr.SideA = a; tr.SideB = b; tr.SideC = c;
            double expectedArea = 6;         
            double Arearez = tr.Area();
            Assert.Equal(expectedArea, Arearez);
        }

        [Theory]
        [InlineData(3, 4, 5)]
        public void Triangle_Perimeter_ShouldReturnCorrectValue(double a, double b, double c)
        {
            Triangle tr = new Triangle();
            tr.SideA = a; tr.SideB = b; tr.SideC = c;
            double expectedPerimeter = 12;
            double actualPerimeter = tr.Perimeter();
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
     

    }
}