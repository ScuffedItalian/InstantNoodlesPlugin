using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace RequirmentPlus
{
    [Plugin("InstantNoodles")]
    public class Plugin
    {
        [Init]
        
        private void Init()
        {
            Console.WriteLine("Plugin has loaded!");
            ExtensionButtons.AddButton(null, "Add Noodle As A Requirment", OnBttnClick1);
      


        }

        private void OnBttnClick1() => RequirementCheck.RegisterRequirement(new ReqClass());
      


        [Exit]
        private void Exit()
        {
            Console.WriteLine("Application has closed!");
        }
    }
}
