using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Boss
    {
        public delegate void MachineStateHandler(int voltage);
        public delegate void UpgradeStateHandler(int upgradeToINT);

        public event MachineStateHandler OnTurnOn;
        public event UpgradeStateHandler OnUpgrade;

        public void Upgrade(int upgradeToINT)
        {
            OnUpgrade(upgradeToINT);
        }
        public void TurnON(int voltage)
        {
            OnTurnOn(voltage);
        }

    }
}
