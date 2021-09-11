namespace Simulation3d
{
    public struct Angle
    {
        private float x;
        public float X
        {
            get { return x; }
            set
            {
                x = value; 
                if (x >= 360)
                {
                    x -= 360; 
                }
                else if (x <= -360)
                {
                    x += 360; 
                }
            }
        }

        private float y;
        public float Y
        {
            get { return y; }
            set
            {
                y = value; 
                if (y >= 360)
                {
                    y -= 360; 
                }
                else if (y <= -360)
                {
                    y += 360; 
                }
            }
        }
        
        private float z;
        public float Z
        {
            get { return z; }
            set 
            {
                z = value; 
                if (z >= 360)
                {
                    z -= 360; 
                }
                else if (z <= -360)
                {
                    z += 360; 
                }
            }
        }
    }
}