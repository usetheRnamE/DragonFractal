namespace Fractals
{
    #region Datebase
    public struct DragonPoint
        {
            public decimal xCoord { get; }
            public decimal yCoord { get; }

            public DragonPoint(decimal xNextCoord, decimal yNextCoord)
            {
                xCoord = xNextCoord;
                yCoord = yNextCoord;
            }
        
            //public override string ToString() => $"({xCoord}, {yCoord})"; 
        }
    #endregion

    #region OldCode

    // double xValue, yValue;

    // private Point point;


    /* public Point Point
       {
           get { return point; }
           set { point = value; }
       }*/

    /*public DragonPoint(double xNextValue,double yNextValue)
      {
          xValue = xNextValue;
          yValue = yNextValue;
      }*/
    #endregion
}