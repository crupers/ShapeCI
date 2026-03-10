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
       [Fact]
        public void RectanglFailedFatal_Test()
        {
           Rectangle rec = new Rectangle();
            rec.Width = 4;
            rec.Height= 5;
            double FatalResult = 100;
            double Arearez = rec.Area(); 
            Assert.Equal(FatalResult, Arearez);

        }

    }
}