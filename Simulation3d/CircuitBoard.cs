namespace Simulation3d
{
    /// <summary>
    /// Provides functionality for rotating 3D model and setting its 
    /// acceleration along each of 3 axis. 
    /// </summary>
    public class CircuitBoard 
    {
        private Angle _Angle; 
        private Acceleration _Accel; 

        private float Temperature = 0.0f; 

        public CircuitBoard()
        {
            _Angle.X = 0.0f; 
            _Angle.Y = 0.0f; 
            _Angle.Z = 0.0f; 
        }

        public float GetTemperature()
        {
            return Temperature; 
        }

        public void SetTemperature(float temp)
        {
            this.Temperature = temp; 
        }

        public Angle GetRotation()
        {
            return _Angle; 
        }

        public void SetRotation(float dx = 0, float dy = 0, float dz = 0)
        {
            _Angle.X += dx; 
            _Angle.Y += dy; 
            _Angle.Z += dz; 
        }

        public Acceleration GetAcceleration()
        {
            return _Accel; 
        }

        public void SetAcceleration(float dx = 0, float dy = 0, float dz = 0)
        {
            _Accel.X = dx; 
            _Accel.Y = dy; 
            _Accel.Z = dz;

            float dxAngle = (float)System.Math.Atan2(_Accel.Y,
                System.Math.Sqrt(System.Math.Pow(_Accel.X, 2) + System.Math.Pow(_Accel.Z, 2))); 
            float dyAngle = (float)System.Math.Atan2(_Accel.X,
                System.Math.Sqrt(System.Math.Pow(_Accel.Y, 2) + System.Math.Pow(_Accel.Z, 2))); 
            float dzAngle = (float)System.Math.Atan2(System.Math.Sqrt(System.Math.Pow(_Accel.X, 2) + System.Math.Pow(_Accel.Y, 2)),
                _Accel.Z);

            this.SetRotation(dxAngle, dyAngle, dzAngle);
        }
    }
}