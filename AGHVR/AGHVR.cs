using System;
using BepInEx;
using VRGIN.Core;

namespace AGHVR
{
    [BepInPlugin(GUID, GUID, Version)]
    public class AGHVR : BaseUnityPlugin
    {
        public const string GUID = "AGHVR";

        public const string Version = "0.1";

        public void Start()
        {
            if (Environment.CommandLine.Contains("--vr"))
            {
                var context = new AGHContext();
                VRManager.Create<AGHInterpreter>(context);
                VR.Manager.SetMode<AGHSeatedMode>();
            }
            //VRLog.Info("Layers: " + string.Join(", ", UnityHelper.GetLayerNames(int.MaxValue)));
            //UnityEngine.SceneManagement.SceneManager.LoadScene(7);
        }
    }
}
