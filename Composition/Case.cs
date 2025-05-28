using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Composition
{
    public sealed class Case
    {
        public void TurnOn()
        {
            Console.WriteLine("Press Power Button");
        }
    }

    public sealed class PowerSupply
    {
        public void TurnOnPower()
        {
            Console.WriteLine("Power Supply turned on");
        }
    }

    public sealed class Motherboard
    {
        public void Boot()
        {
            Console.WriteLine("Booting....");
        }
    }

    public sealed class HardDrive
    {
        private readonly int _driveSize;
        public HardDrive(int driveSize)
        {
            _driveSize = driveSize;
        }
        public void WriteData()
        {
            Console.WriteLine($"Loading data into RAM with capacity of {_driveSize} GB");
        }
    }

    //composite class
    public class Computer
    {
        private readonly Case _case;
        private readonly PowerSupply _powerSuppy;
        private readonly Motherboard _motherBoard;
        private readonly HardDrive _hardDrive;

        public Computer(Case cases, PowerSupply powerSupply, Motherboard motherboard, HardDrive hardDrive)
        {
            _case = cases;
            _powerSuppy = powerSupply;
            _motherBoard = motherboard;
            _hardDrive = hardDrive;
        }

        //below method is encapsulated. 
        public void PowerOn()
        {
            _case.TurnOn();
            _powerSuppy.TurnOnPower();
            _motherBoard.Boot();
            _hardDrive.WriteData();
        }
    }
}
