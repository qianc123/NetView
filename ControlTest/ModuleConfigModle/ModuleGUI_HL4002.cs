﻿
using ControlTest.TypeConvertClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlTest.ModuleConfigModle
{
    [Serializable()]
    public class ModuleGUI_HL4002 : ModuleGUIBase
    {
        Tcv tcv = new Tcv();
        Dictionary<object, string> StrEnumType = null;
        Dictionary<object, string> StrEnumAccuracy = null;

        protected override int GuiStringListNumber { get; } = 11;
        public ModuleGUI_HL4002()
        {
            DeviceName = EnumDeviceName.HL4002;
            Function = "AOx4Ch. 4-20mA";
            StrEnumType = tcv.GetEnumValueDesDic(typeof(EnumHL4002Type));
            StrEnumAccuracy = tcv.GetEnumValueDesDic(typeof(EnumHL4002Accuracy));
        }

        [TypeConverter(typeof(Tcv))]
        public EnumHL4002Type Ch1_Output_Type { get; set; }
        [TypeConverter(typeof(Tcv))]
        public EnumHL4002Accuracy Ch1_Accuracy { get; set; }

        [TypeConverter(typeof(Tcv))]
        public EnumHL4002Type Ch2_Output_Type { get; set; }
        [TypeConverter(typeof(Tcv))]
        public EnumHL4002Accuracy Ch2_Accuracy { get; set; }

        [TypeConverter(typeof(Tcv))]
        public EnumHL4002Type Ch3_Output_Type { get; set; }
        [TypeConverter(typeof(Tcv))]
        public EnumHL4002Accuracy Ch3_Accuracy { get; set; }

        [TypeConverter(typeof(Tcv))]
        public EnumHL4002Type Ch4_Output_Type { get; set; }
        [TypeConverter(typeof(Tcv))]
        public EnumHL4002Accuracy Ch4_Accuracy { get; set; }


        public override void FromString(params string[] ParaList)
        {
            EnumHL4002Type type;
            EnumHL4002Accuracy acc;
            if (ParaList.Length != GuiStringListNumber)
                throw new Exception($"Wrong para number when parse {DeviceName.ToString()} formstring");
            GuiStringList.Clear();
            foreach (var it in ParaList)
                GuiStringList.Add(it);
            Name = GuiStringList[0];
            Function = GuiStringList[1];
            Plug_Sequence = GuiStringList[2];

            Enum.TryParse(StrEnumType.Where(a => a.Value.Equals(GuiStringList[3])).First().Key.ToString(), out type);
            Enum.TryParse(StrEnumAccuracy.Where(a => a.Value.Equals(GuiStringList[4])).First().Key.ToString(), out acc);
            Ch1_Output_Type = type;
            Ch1_Accuracy = acc;

            Enum.TryParse(StrEnumType.Where(a => a.Value.Equals(GuiStringList[5])).First().Key.ToString(), out type);
            Enum.TryParse(StrEnumAccuracy.Where(a => a.Value.Equals(GuiStringList[6])).First().Key.ToString(), out acc);
            Ch2_Output_Type = type;
            Ch2_Accuracy = acc;


            Enum.TryParse(StrEnumType.Where(a => a.Value.Equals(GuiStringList[7])).First().Key.ToString(), out type);
            Enum.TryParse(StrEnumAccuracy.Where(a => a.Value.Equals(GuiStringList[8])).First().Key.ToString(), out acc);
            Ch3_Output_Type = type;
            Ch3_Accuracy = acc;

            Enum.TryParse(StrEnumType.Where(a => a.Value.Equals(GuiStringList[9])).First().Key.ToString(), out type);
            Enum.TryParse(StrEnumAccuracy.Where(a => a.Value.Equals(GuiStringList[10])).First().Key.ToString(), out acc);
            Ch4_Output_Type = type;
            Ch4_Accuracy = acc;

        }

        protected override void SetProfile()
        {
            GuiStringList.Clear();
            GetListFromStr(GuiStringList,
                Name,
                Function,
                Plug_Sequence,
                StrEnumType[Ch1_Output_Type],
                StrEnumAccuracy[Ch1_Accuracy],

                StrEnumType[Ch2_Output_Type],
                StrEnumAccuracy[Ch2_Accuracy],

                StrEnumType[Ch3_Output_Type],
                StrEnumAccuracy[Ch3_Accuracy],

                StrEnumType[Ch4_Output_Type],
                StrEnumAccuracy[Ch4_Accuracy]);

        }
    }
}
