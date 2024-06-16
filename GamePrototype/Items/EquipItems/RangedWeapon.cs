﻿using GamePrototype.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototype.Items.EquipItems
{
    public class RangedWeapon : EquipItem
    {
        public RangedWeapon(uint maxDurability, string name, uint distance) : base(maxDurability, name)
        {

        }
        public override EquipSlot Slot { get; }


    }
}
