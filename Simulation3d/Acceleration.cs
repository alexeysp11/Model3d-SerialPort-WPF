namespace Simulation3d
{
    public struct Acceleration
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public void AdjustX()
        {
            if (X > 0) 
            {
                X -= 1; 
            }
            else if (X < 0)
            {
                X += 1;
            }
        }

        public void AdjustY()
        {
            if (Y > 0) 
            {
                Y -= 1; 
            }
            else if (Y < 0)
            {
                Y += 1;
            }
        }

        public void AdjustZ()
        {
            if (Z > 0) 
            {
                Z -= 1; 
            }
            else if (Z < 0)
            {
                Z += 1;
            }
        }
    }
}