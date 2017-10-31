﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Lights
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Action recording.
    /// </summary>
    [TestModule("b04b9662-4c3f-4cf6-bb37-937b3a315a57", ModuleType.Recording, 1)]
    public partial class Action : ITestModule
    {
        /// <summary>
        /// Holds an instance of the LightsRepository repository.
        /// </summary>
        public static LightsRepository repo = LightsRepository.Instance;

        static Action instance = new Action();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Action()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Action Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SnapXUntitled.Container59648.BackLightBigMode' at 7;12.", repo.SnapXUntitled.Container59648.BackLightBigModeInfo, new RecordItemIndex(0));
            repo.SnapXUntitled.Container59648.BackLightBigMode.DoubleClick("7;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '70' with focus on 'SnapXUntitled.Container59648.BackLightBigMode'.", repo.SnapXUntitled.Container59648.BackLightBigModeInfo, new RecordItemIndex(1));
            repo.SnapXUntitled.Container59648.BackLightBigMode.PressKeys("70");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SnapXUntitled.Container59648.BackLightBigMode'.", repo.SnapXUntitled.Container59648.BackLightBigModeInfo, new RecordItemIndex(2));
            repo.SnapXUntitled.Container59648.BackLightBigMode.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='70') on item 'SnapXUntitled.Container59648.BackLightBigMode'.", repo.SnapXUntitled.Container59648.BackLightBigModeInfo, new RecordItemIndex(3));
                Validate.Attribute(repo.SnapXUntitled.Container59648.BackLightBigModeInfo, "WindowText", "70", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Container59648.SwitchFromBigToFFW' at 18;16.", repo.SnapXUntitled.Container59648.SwitchFromBigToFFWInfo, new RecordItemIndex(4));
            repo.SnapXUntitled.Container59648.SwitchFromBigToFFW.Click("18;16");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='70') on item 'SnapXUntitled.Container59648.BackLightFFW'.", repo.SnapXUntitled.Container59648.BackLightFFWInfo, new RecordItemIndex(5));
                Validate.Attribute(repo.SnapXUntitled.Container59648.BackLightFFWInfo, "WindowText", "70", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SnapXUntitled.Container59648.BackLightFFW' at 8;10.", repo.SnapXUntitled.Container59648.BackLightFFWInfo, new RecordItemIndex(6));
            repo.SnapXUntitled.Container59648.BackLightFFW.DoubleClick("8;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '60{Return}' with focus on 'SnapXUntitled.Container59648.BackLightFFW'.", repo.SnapXUntitled.Container59648.BackLightFFWInfo, new RecordItemIndex(7));
            repo.SnapXUntitled.Container59648.BackLightFFW.PressKeys("60{Return}");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='60') on item 'SnapXUntitled.Container59648.BackLightFFW'.", repo.SnapXUntitled.Container59648.BackLightFFWInfo, new RecordItemIndex(8));
                Validate.Attribute(repo.SnapXUntitled.Container59648.BackLightFFWInfo, "WindowText", "60", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Container59648.SwitchFromFFWToBig' at Center.", repo.SnapXUntitled.Container59648.SwitchFromFFWToBigInfo, new RecordItemIndex(9));
            repo.SnapXUntitled.Container59648.SwitchFromFFWToBig.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='60') on item 'SnapXUntitled.Container59648.BackLightBigMode'.", repo.SnapXUntitled.Container59648.BackLightBigModeInfo, new RecordItemIndex(10));
                Validate.Attribute(repo.SnapXUntitled.Container59648.BackLightBigModeInfo, "WindowText", "60", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SnapXUntitled.Container59648.SurfaceLightBigMode' at 13;14.", repo.SnapXUntitled.Container59648.SurfaceLightBigModeInfo, new RecordItemIndex(11));
            repo.SnapXUntitled.Container59648.SurfaceLightBigMode.DoubleClick("13;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '50{Return}' with focus on 'SnapXUntitled.Container59648.SurfaceLightBigMode'.", repo.SnapXUntitled.Container59648.SurfaceLightBigModeInfo, new RecordItemIndex(12));
            repo.SnapXUntitled.Container59648.SurfaceLightBigMode.PressKeys("50{Return}");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='50') on item 'SnapXUntitled.Container59648.SurfaceLightBigMode'.", repo.SnapXUntitled.Container59648.SurfaceLightBigModeInfo, new RecordItemIndex(13));
                Validate.Attribute(repo.SnapXUntitled.Container59648.SurfaceLightBigModeInfo, "WindowText", "50", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(13)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Container59648.SwitchFromBigToFFW' at Center.", repo.SnapXUntitled.Container59648.SwitchFromBigToFFWInfo, new RecordItemIndex(14));
            repo.SnapXUntitled.Container59648.SwitchFromBigToFFW.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='50') on item 'SnapXUntitled.Container59648.SurfaceLightFFW'.", repo.SnapXUntitled.Container59648.SurfaceLightFFWInfo, new RecordItemIndex(15));
                Validate.Attribute(repo.SnapXUntitled.Container59648.SurfaceLightFFWInfo, "WindowText", "50", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SnapXUntitled.Container59648.SurfaceLightFFW' at 12;10.", repo.SnapXUntitled.Container59648.SurfaceLightFFWInfo, new RecordItemIndex(16));
            repo.SnapXUntitled.Container59648.SurfaceLightFFW.DoubleClick("12;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '30{Return}' with focus on 'SnapXUntitled.Container59648.SurfaceLightFFW'.", repo.SnapXUntitled.Container59648.SurfaceLightFFWInfo, new RecordItemIndex(17));
            repo.SnapXUntitled.Container59648.SurfaceLightFFW.PressKeys("30{Return}");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='30') on item 'SnapXUntitled.Container59648.SurfaceLightFFW'.", repo.SnapXUntitled.Container59648.SurfaceLightFFWInfo, new RecordItemIndex(18));
                Validate.Attribute(repo.SnapXUntitled.Container59648.SurfaceLightFFWInfo, "WindowText", "30", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(18)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Container59648.SwitchFromFFWToBig' at Center.", repo.SnapXUntitled.Container59648.SwitchFromFFWToBigInfo, new RecordItemIndex(19));
            repo.SnapXUntitled.Container59648.SwitchFromFFWToBig.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='30') on item 'SnapXUntitled.Container59648.SurfaceLightBigMode'.", repo.SnapXUntitled.Container59648.SurfaceLightBigModeInfo, new RecordItemIndex(20));
                Validate.Attribute(repo.SnapXUntitled.Container59648.SurfaceLightBigModeInfo, "WindowText", "30", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(20)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SnapXUntitled.Container59648.SRLBigMode' at 11;12.", repo.SnapXUntitled.Container59648.SRLBigModeInfo, new RecordItemIndex(21));
            repo.SnapXUntitled.Container59648.SRLBigMode.DoubleClick("11;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '70' with focus on 'SnapXUntitled.Container59648.SRLBigMode'.", repo.SnapXUntitled.Container59648.SRLBigModeInfo, new RecordItemIndex(22));
            repo.SnapXUntitled.Container59648.SRLBigMode.PressKeys("70");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SnapXUntitled.Container59648.SRLBigMode'.", repo.SnapXUntitled.Container59648.SRLBigModeInfo, new RecordItemIndex(23));
            repo.SnapXUntitled.Container59648.SRLBigMode.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='70') on item 'SnapXUntitled.Container59648.SRLBigMode'.", repo.SnapXUntitled.Container59648.SRLBigModeInfo, new RecordItemIndex(24));
                Validate.Attribute(repo.SnapXUntitled.Container59648.SRLBigModeInfo, "WindowText", "70", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(24)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Container59648.SwitchFromBigToFFW' at Center.", repo.SnapXUntitled.Container59648.SwitchFromBigToFFWInfo, new RecordItemIndex(25));
            repo.SnapXUntitled.Container59648.SwitchFromBigToFFW.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='70') on item 'SnapXUntitled.Container59648.SRLFFW'.", repo.SnapXUntitled.Container59648.SRLFFWInfo, new RecordItemIndex(26));
                Validate.Attribute(repo.SnapXUntitled.Container59648.SRLFFWInfo, "WindowText", "70", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(26)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SnapXUntitled.Container59648.SRLFFW' at 12;10.", repo.SnapXUntitled.Container59648.SRLFFWInfo, new RecordItemIndex(27));
            repo.SnapXUntitled.Container59648.SRLFFW.DoubleClick("12;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '20{Return}' with focus on 'SnapXUntitled.Container59648.SRLFFW'.", repo.SnapXUntitled.Container59648.SRLFFWInfo, new RecordItemIndex(28));
            repo.SnapXUntitled.Container59648.SRLFFW.PressKeys("20{Return}");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='20') on item 'SnapXUntitled.Container59648.SRLFFW'.", repo.SnapXUntitled.Container59648.SRLFFWInfo, new RecordItemIndex(29));
                Validate.Attribute(repo.SnapXUntitled.Container59648.SRLFFWInfo, "WindowText", "20", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(29)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Container59648.SwitchFromFFWToBig' at Center.", repo.SnapXUntitled.Container59648.SwitchFromFFWToBigInfo, new RecordItemIndex(30));
            repo.SnapXUntitled.Container59648.SwitchFromFFWToBig.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='20') on item 'SnapXUntitled.Container59648.SRLBigMode'.", repo.SnapXUntitled.Container59648.SRLBigModeInfo, new RecordItemIndex(31));
                Validate.Attribute(repo.SnapXUntitled.Container59648.SRLBigModeInfo, "WindowText", "20", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(31)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SnapXUntitled.Container59648.SRLSlider' at Center.", repo.SnapXUntitled.Container59648.SRLSliderInfo, new RecordItemIndex(32));
            repo.SnapXUntitled.Container59648.SRLSlider.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -2700 units.", new RecordItemIndex(33));
            Mouse.ScrollWheel(-2700);
            Delay.Milliseconds(500);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='0') on item 'SnapXUntitled.Container59648.SRLBigMode'.", repo.SnapXUntitled.Container59648.SRLBigModeInfo, new RecordItemIndex(34));
                Validate.Attribute(repo.SnapXUntitled.Container59648.SRLBigModeInfo, "WindowText", "0", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(34)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SnapXUntitled.Container59648.SurfaceSlider' at Center.", repo.SnapXUntitled.Container59648.SurfaceSliderInfo, new RecordItemIndex(35));
            repo.SnapXUntitled.Container59648.SurfaceSlider.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -2700 units.", new RecordItemIndex(36));
            Mouse.ScrollWheel(-2700);
            Delay.Milliseconds(100);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='0') on item 'SnapXUntitled.Container59648.SurfaceLightBigMode'.", repo.SnapXUntitled.Container59648.SurfaceLightBigModeInfo, new RecordItemIndex(37));
                Validate.Attribute(repo.SnapXUntitled.Container59648.SurfaceLightBigModeInfo, "WindowText", "0", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(37)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SnapXUntitled.Container59648.BackSlider' at 21;55.", repo.SnapXUntitled.Container59648.BackSliderInfo, new RecordItemIndex(38));
            repo.SnapXUntitled.Container59648.BackSlider.MoveTo("21;55");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -2700 units.", new RecordItemIndex(39));
            Mouse.ScrollWheel(-2700);
            Delay.Milliseconds(100);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='0') on item 'SnapXUntitled.Container59648.BackLightBigMode'.", repo.SnapXUntitled.Container59648.BackLightBigModeInfo, new RecordItemIndex(40));
                Validate.Attribute(repo.SnapXUntitled.Container59648.BackLightBigModeInfo, "WindowText", "0", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(40)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Container59648.SwitchFromBigToFFW' at Center.", repo.SnapXUntitled.Container59648.SwitchFromBigToFFWInfo, new RecordItemIndex(41));
            repo.SnapXUntitled.Container59648.SwitchFromBigToFFW.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='0') on item 'SnapXUntitled.Container59648.SRLFFW'.", repo.SnapXUntitled.Container59648.SRLFFWInfo, new RecordItemIndex(42));
                Validate.Attribute(repo.SnapXUntitled.Container59648.SRLFFWInfo, "WindowText", "0", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(42)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='0') on item 'SnapXUntitled.Container59648.SurfaceLightFFW'.", repo.SnapXUntitled.Container59648.SurfaceLightFFWInfo, new RecordItemIndex(43));
                Validate.Attribute(repo.SnapXUntitled.Container59648.SurfaceLightFFWInfo, "WindowText", "0", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(43)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='0') on item 'SnapXUntitled.Container59648.BackLightFFW'.", repo.SnapXUntitled.Container59648.BackLightFFWInfo, new RecordItemIndex(44));
                Validate.Attribute(repo.SnapXUntitled.Container59648.BackLightFFWInfo, "WindowText", "0", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(44)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SnapXUntitled.Container59648.BoostFFW' at 14;10.", repo.SnapXUntitled.Container59648.BoostFFWInfo, new RecordItemIndex(45));
            repo.SnapXUntitled.Container59648.BoostFFW.DoubleClick("14;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2' with focus on 'SnapXUntitled.Container59648.BoostFFW'.", repo.SnapXUntitled.Container59648.BoostFFWInfo, new RecordItemIndex(46));
            repo.SnapXUntitled.Container59648.BoostFFW.PressKeys("2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SnapXUntitled.Container59648.BoostFFW'.", repo.SnapXUntitled.Container59648.BoostFFWInfo, new RecordItemIndex(47));
            repo.SnapXUntitled.Container59648.BoostFFW.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='2') on item 'SnapXUntitled.Container59648.BoostFFW'.", repo.SnapXUntitled.Container59648.BoostFFWInfo, new RecordItemIndex(48));
                Validate.Attribute(repo.SnapXUntitled.Container59648.BoostFFWInfo, "WindowText", "2", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(48)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Container59648.SwitchFromFFWToBig' at Center.", repo.SnapXUntitled.Container59648.SwitchFromFFWToBigInfo, new RecordItemIndex(49));
            repo.SnapXUntitled.Container59648.SwitchFromFFWToBig.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='2') on item 'SnapXUntitled.Container59648.BoostBigMode'.", repo.SnapXUntitled.Container59648.BoostBigModeInfo, new RecordItemIndex(50));
                Validate.Attribute(repo.SnapXUntitled.Container59648.BoostBigModeInfo, "WindowText", "2", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(50)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SnapXUntitled.Container59648.BoostBigMode' at 14;12.", repo.SnapXUntitled.Container59648.BoostBigModeInfo, new RecordItemIndex(51));
            repo.SnapXUntitled.Container59648.BoostBigMode.DoubleClick("14;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '3' with focus on 'SnapXUntitled.Container59648.BoostBigMode'.", repo.SnapXUntitled.Container59648.BoostBigModeInfo, new RecordItemIndex(52));
            repo.SnapXUntitled.Container59648.BoostBigMode.PressKeys("3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SnapXUntitled.Container59648.BoostBigMode'.", repo.SnapXUntitled.Container59648.BoostBigModeInfo, new RecordItemIndex(53));
            repo.SnapXUntitled.Container59648.BoostBigMode.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='3') on item 'SnapXUntitled.Container59648.BoostBigMode'.", repo.SnapXUntitled.Container59648.BoostBigModeInfo, new RecordItemIndex(54));
                Validate.Attribute(repo.SnapXUntitled.Container59648.BoostBigModeInfo, "WindowText", "3", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(54)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Container59648.SwitchFromBigToFFW' at Center.", repo.SnapXUntitled.Container59648.SwitchFromBigToFFWInfo, new RecordItemIndex(55));
            repo.SnapXUntitled.Container59648.SwitchFromBigToFFW.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='3') on item 'SnapXUntitled.Container59648.BoostFFW'.", repo.SnapXUntitled.Container59648.BoostFFWInfo, new RecordItemIndex(56));
                Validate.Attribute(repo.SnapXUntitled.Container59648.BoostFFWInfo, "WindowText", "3", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(56)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Container59648.SwitchFromFFWToBig' at Center.", repo.SnapXUntitled.Container59648.SwitchFromFFWToBigInfo, new RecordItemIndex(57));
            repo.SnapXUntitled.Container59648.SwitchFromFFWToBig.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=40,Height=119}) on item 'SnapXUntitled.Container59648.SRLSlider'.", repo.SnapXUntitled.Container59648.SRLSliderInfo, new RecordItemIndex(58));
                Validate.ContainsImage(repo.SnapXUntitled.Container59648.SRLSliderInfo, SRLSlider_Screenshot1, SRLSlider_Screenshot1_Options, Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(58)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=40,Height=119}) on item 'SnapXUntitled.Container59648.SurfaceSlider'.", repo.SnapXUntitled.Container59648.SurfaceSliderInfo, new RecordItemIndex(59));
                Validate.ContainsImage(repo.SnapXUntitled.Container59648.SurfaceSliderInfo, SurfaceSlider_Screenshot1, SurfaceSlider_Screenshot1_Options, Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(59)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=40,Height=119}) on item 'SnapXUntitled.Container59648.BackSlider'.", repo.SnapXUntitled.Container59648.BackSliderInfo, new RecordItemIndex(60));
                Validate.ContainsImage(repo.SnapXUntitled.Container59648.BackSliderInfo, BackSlider_Screenshot1, BackSlider_Screenshot1_Options, Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(60)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Container59648.SwitchFromBigToFFW' at Center.", repo.SnapXUntitled.Container59648.SwitchFromBigToFFWInfo, new RecordItemIndex(61));
            repo.SnapXUntitled.Container59648.SwitchFromBigToFFW.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=50,Height=50}) on item 'SnapXUntitled.Container59648.SRLImageFFW'.", repo.SnapXUntitled.Container59648.SRLImageFFWInfo, new RecordItemIndex(62));
                Validate.ContainsImage(repo.SnapXUntitled.Container59648.SRLImageFFWInfo, SRLImageFFW_Screenshot2, SRLImageFFW_Screenshot2_Options, Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(62)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=50,Height=50}) on item 'SnapXUntitled.Container59648.SurfaceImageFFW'.", repo.SnapXUntitled.Container59648.SurfaceImageFFWInfo, new RecordItemIndex(63));
                Validate.ContainsImage(repo.SnapXUntitled.Container59648.SurfaceImageFFWInfo, SurfaceImageFFW_Screenshot2, SurfaceImageFFW_Screenshot2_Options, Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(63)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=50,Height=50}) on item 'SnapXUntitled.Container59648.BackImageFFW'.", repo.SnapXUntitled.Container59648.BackImageFFWInfo, new RecordItemIndex(64));
                Validate.ContainsImage(repo.SnapXUntitled.Container59648.BackImageFFWInfo, BackImageFFW_Screenshot2, BackImageFFW_Screenshot2_Options, Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(64)); }
            
        }

#region Image Feature Data
        CompressedImage SRLSlider_Screenshot1
        { get { return repo.SnapXUntitled.Container59648.SRLSliderInfo.GetScreenshot1(new Rectangle(0, 0, 40, 119)); } }

        Imaging.FindOptions SRLSlider_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage SurfaceSlider_Screenshot1
        { get { return repo.SnapXUntitled.Container59648.SurfaceSliderInfo.GetScreenshot1(new Rectangle(0, 0, 40, 119)); } }

        Imaging.FindOptions SurfaceSlider_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage BackSlider_Screenshot1
        { get { return repo.SnapXUntitled.Container59648.BackSliderInfo.GetScreenshot1(new Rectangle(0, 0, 40, 119)); } }

        Imaging.FindOptions BackSlider_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage SRLImageFFW_Screenshot2
        { get { return repo.SnapXUntitled.Container59648.SRLImageFFWInfo.GetScreenshot2(new Rectangle(0, 0, 50, 50)); } }

        Imaging.FindOptions SRLImageFFW_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage SurfaceImageFFW_Screenshot2
        { get { return repo.SnapXUntitled.Container59648.SurfaceImageFFWInfo.GetScreenshot2(new Rectangle(0, 0, 50, 50)); } }

        Imaging.FindOptions SurfaceImageFFW_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage BackImageFFW_Screenshot2
        { get { return repo.SnapXUntitled.Container59648.BackImageFFWInfo.GetScreenshot2(new Rectangle(0, 0, 50, 50)); } }

        Imaging.FindOptions BackImageFFW_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
