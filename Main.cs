using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using UnityEngine;

[module: UnverifiableCode]
// Required for accessing private members
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

//アップデート予定？
//最大値の表示
//スタックサイズボタン
//レシピアイコンに現在の所持数を表示
//必要素材を表示し続け、数がそろったら自動でタスクに入れる

namespace DSPReplicatorPlus
{
    [BepInPlugin("Appun.DSP.plugin.DSPReplicatorPlus", "DSPReplicatorPlus", "0.0.3")]
    [HarmonyPatch]
    public class Main : BaseUnityPlugin
    {

        public static ConfigEntry<float> speedMultiplier;
        public static ConfigEntry<float> maximumSpeed;
        public static ConfigEntry<KeyCode> KeyConfig;



        public void Start()
        {
            LogManager.Logger = Logger;
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());

            UI.Create();
        }

        public class LogManager
        {
            public static ManualLogSource Logger;
        }
    }
}