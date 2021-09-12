# Model3d-SerialPort-WPF

`Model3d-SerialPort-WPF` provides visual representation of the received data (temperature and relative acceleration from 3 axis accelerometer) from microcontroller. 

This app is written in `C#` using **WPF**. 

![RotationOnGui](Docs/img/Usage/RotationOnGui.png)

`Model3d-SerialPort-WPF` might be considered as an addition to [this project](https://github.com/alexeysp11/STM32F4-Accel-Temperature). 

This application allows you to rotate a *3D model* on the screen, rotating a *circuit board* on which an *accelerometer* is attached. 
Getting relative acceleration of an object, you can calculate its rotation as follows: 
```C#
namespace Simulation3d
{
    public class PhysicalModel3D
    {
        ... 
        /// <summary>
        /// Sets values of acceleration along each of 3 axis. 
        /// </summary>
        public void SetAcceleration(float dx = 0, float dy = 0, float dz = 0)
        {
            // Adjust all accelerations. 
            accel.X += dx; 
            accel.Y += dy; 
            accel.Z += dz;

            // Calculate rotation using acceleration. 
            float dxAngle = (float)System.Math.Atan2(accel.Y,
                System.Math.Sqrt(System.Math.Pow(accel.X, 2) + System.Math.Pow(accel.Z, 2))); 
            float dyAngle = (float)System.Math.Atan2(accel.X,
                System.Math.Sqrt(System.Math.Pow(accel.Y, 2) + System.Math.Pow(accel.Z, 2))); 
            float dzAngle = (float)System.Math.Atan2(System.Math.Sqrt(System.Math.Pow(accel.X, 2) + System.Math.Pow(accel.Y, 2)),
                accel.Z);

            this.SetRotation(dxAngle, dyAngle, dzAngle);
        }
    }
}
```

## How to use 

### Prerequisites

- Windows OS; 
- .NET Core 3.1; 
- Any text editor (*VS Code*, *Sublime Text*, *Notepad++* etc) or Visual Studio; 
- Windows command line (if you do not use Visual Studio). 

Dependencies for `Model3d-SerialPort-WPF`: 
- System.IO.Ports (Version 4.4.0). 

### COM-port configuration

For the program to work correctly, it is critical to **set a delay** for *data transmission* from the microcontroller to the computer so that `Model3d-SerialPort-WPF` does not hang.
Because when there is a constant stream of data, at best, `Model3d-SerialPort-WPF` stops responding to anything, but most often it just crashes with an **APPCRASH** exception.

**COM-port configuration** (parity, number of stop bits, number of data bits, baud rate) is made in the code itself depending on technical requirements.
Click [here](Docs/DataTransmission.md) to read full information on how to configure data transmission in this application. 

### How to download this repository and edit code 

In order to download this repository, just type into console the following command: 
```
git clone https://github.com/alexeysp11/Model3d-SerialPort-WPF
```

Then just open main directory using any text editor and just edit code. 

In order to open `Simulation3d` application with Visual Studio, just open `Simulation3d.sln` solution by double click. 

### How to run 

If you are not using Visual Studio, you can run this app using *Windows command line*. 
So just write the following command into console: 
```
run.cmd
```
