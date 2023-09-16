using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

namespace TK.Nanite.Alpha
{
    public class FakerNaniteEditor
    {
        const string MenuPath = "FakerNanite/";
        const string MenuItempath = "Enable";
        //const string MenuItempath2 = "Disable";

        static GameObject NaniteController;
        
        [MenuItem(MenuPath + MenuItempath)]
        static void EnableNanite()
        {
            if (!NaniteController)
            {
                NaniteController = new GameObject("NaniteController");
                NaniteController.AddComponent<FakerActiveController>();
            }
        }
        

    }
}
#endif