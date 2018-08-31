using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace Agriculture
{
    public partial class Action : System.Web.UI.Page
    {
        //Initialise properties
        Brick brick;
        OutputPort portA = OutputPort.A;
        OutputPort portB = OutputPort.B;
        OutputPort portC = OutputPort.C;
        OutputPort portD = OutputPort.D;

        
        protected async void Page_Load(object sender, EventArgs e)
        {
            //Define and connect to brick
            brick = new Brick(new UsbCommunication());
            Debug.WriteLine(brick.Ports[InputPort.One].SIValue);
            await brick.ConnectAsync();
        }

        protected void btnTest_Click(object sender, EventArgs e)
        {
            Turn(portA, 100,1000);
        }

        protected void btnTest2_Click(object sender, EventArgs e)
        {
            Turn(portA, -100,1000);
        }

        //Method to rotate the motor
        //Note: this is actually slow if you wish to run multiple commands at once.
        //I hardcoded an example below under this method.
        protected async void Turn(OutputPort port,int power,uint duration)
        {
            await brick.DirectCommand.TurnMotorAtPowerForTimeAsync(port, power, duration, true);
        }
        
        protected async void EfficientTurn()
        {
            //These are instructions 
            brick.BatchCommand.TurnMotorAtPowerForTime(portA, 50, 1000, true);
            brick.BatchCommand.TurnMotorAtPowerForTime(portB, -50, 1000, true);
            brick.BatchCommand.TurnMotorAtPowerForTime(portC, 100, 3000, true);
            brick.BatchCommand.TurnMotorAtPowerForTime(portD, -10, 200, true);

            //This line sends all the instructions together
            await brick.BatchCommand.SendCommandAsync();
        }



        /* Am just messing around here.
        protected async void play()
        {
            brick.BatchCommand.PlayTone(10,262,500);
            brick.BatchCommand.PlayTone(10,262,500);
            brick.BatchCommand.PlayTone(10,294,1000);
            brick.BatchCommand.PlayTone(10,349,1000);
            brick.BatchCommand.PlayTone(10,330,2000);
            brick.BatchCommand.PlayTone(10,262,500);
            brick.BatchCommand.PlayTone(10,262,500);
            brick.BatchCommand.PlayTone(10,294,1000);

            brick.BatchCommand.PlayTone(10,262,1000);
            brick.BatchCommand.PlayTone(10,392,1000);
            brick.BatchCommand.PlayTone(10,349,2000);
            brick.BatchCommand.PlayTone(10,262,500);
            brick.BatchCommand.PlayTone(10,262,500);
            brick.BatchCommand.PlayTone(10,523,1000);
            brick.BatchCommand.PlayTone(10,440,1000);
            brick.BatchCommand.PlayTone(10,349,330);

            brick.BatchCommand.PlayTone(10,294,3000);
            brick.BatchCommand.PlayTone(10,486,500);
            brick.BatchCommand.PlayTone(10,466,500);
            brick.BatchCommand.PlayTone(10,440,1000);
            brick.BatchCommand.PlayTone(10,349,1000);
            brick.BatchCommand.PlayTone(10,392,1000);
            brick.BatchCommand.PlayTone(10,349,2000);

            await brick.BatchCommand.SendCommandAsync();

            //brick.BatchCommand.PlayTone(10,,);
        }
        */

    }
}