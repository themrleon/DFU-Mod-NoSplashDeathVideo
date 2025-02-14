using UnityEngine;
using DaggerfallWorkshop.Game.Utility.ModSupport; // Required for mod support
using DaggerfallWorkshop.Game.Entity; // Required for EntityEffectManager
using DaggerfallWorkshop.Game; // Required for GameManager

public class NoSplashDeathVideoMod : MonoBehaviour
{
    public static Mod Mod;

    [Invoke(StateManager.StateTypes.Start, 0)]
    public static void Init(InitParams initParams)
    {
        // Store the mod reference
        Mod = initParams.Mod;

        // Create a new GameObject to hold the mod component
        GameObject go = new GameObject(Mod.Title);
        go.AddComponent<NoSplashDeathVideoMod>();

        Mod.IsReady = true;

        // Disable splash and death videos (ANIM0001.VID and ANIM0012.VID)
        DaggerfallUI.Instance.enableVideos = false;
    }
}
