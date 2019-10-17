using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class ConsoleView : UserControl
    {
        public ConsoleView()
        {
            InitializeComponent();
        }

        private RobotConsole robotConsole;

        public RobotConsole RobotConsole
        {
            get { return robotConsole; }
            set
            {
                robotConsole = value;
                if (robotConsole != null)
                {

                    //jeder LedView das entsprechende Led zuweisen
                    ledView1.Led = robotConsole[Leds.Led1];
                    ledView2.Led = robotConsole[Leds.Led2];
                    ledView3.Led = robotConsole[Leds.Led3];
                    ledView4.Led = robotConsole[Leds.Led4];

                    //jeder SwitchView den entsprechenden Swicht zuweisen
                    switchView1.Switch = robotConsole[Switches.Switch1];
                    switchView2.Switch = robotConsole[Switches.Switch2];
                    switchView3.Switch = robotConsole[Switches.Switch3];
                    switchView4.Switch = robotConsole[Switches.Switch4];
                }
            }
        }

        private void switchView1_Click(object sender, EventArgs e)
        {

        }

        private void ledView4_Click(object sender, EventArgs e)
        {

        }

        private void ledView3_Click(object sender, EventArgs e)
        {

        }

        private void ledView2_Click(object sender, EventArgs e)
        {

        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}