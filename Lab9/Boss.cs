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
        public delegate void UpgradeStateHandler(int version);

        public event MachineStateHandler OnTurnOn;
        public event UpgradeStateHandler OnUpgrade;

        public void Upgrade(int version)
        {
            OnUpgrade(version);
        }
        public void TurnOn(int voltage)
        {
            OnTurnOn(voltage);
        }

    }
}
