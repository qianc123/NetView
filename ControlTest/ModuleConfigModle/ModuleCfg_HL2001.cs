﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlTest.ModuleConfigModle
{
    public class ModuleCfg_HL2001 : ModuleCfgModleBase
    {
        protected override int GuiStringListNumber { get; } = 3;

        public ModuleCfg_HL2001()
        {
            DeviceName = EnumDeviceName.HL2001;
            Function = "DO8xDC24V 0.5A";
        }
        public override void FromString(params string[] ParaList)
        {
            if (ParaList.Length != GuiStringListNumber)
                throw new Exception($"Wrong para number when parse {DeviceName.ToString()} formstring");
            GuiStringList.Clear();
            foreach (var it in ParaList)
                GuiStringList.Add(it);
            Name = GuiStringList[0];
            Function = GuiStringList[1];
            Plug_Sequence = GuiStringList[2];
     
        }

        protected override void SetProfile()
        {
            GuiStringList.Clear();
           
            GuiStringList.Add(Name);
        
            GuiStringList.Add(Function);
          
            GuiStringList.Add(Plug_Sequence);
        }
    }
   
}
