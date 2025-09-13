using UnityEngine.UI;
using HarmonyLib;

namespace DSPReplicatorPlus
{
    [HarmonyPatch]
    internal class Patch
    {
        public static int SelectedRecipeIndexBk = -1;
        public static int currentTypeBk = 1;
        public static RecipeProto resipeBk;

        //ボタンのインタラクティブ判定の切り替え
        [HarmonyPostfix, HarmonyPatch(typeof(UIReplicatorWindow), "_OnUpdate")]
        public static void UIReplicatorWindow_OnUpdate_Postfix(UIReplicatorWindow __instance)
        {
            if (__instance.selectedRecipe == null)
            {
                return;
            }

            if (GameMain.sandboxToolsEnabled && __instance.isInstantItem)
            {
                UI.headMax.GetComponent<Button>().interactable = true;
                UI.head500.GetComponent<Button>().interactable = true;
                UI.head100.GetComponent<Button>().interactable = true;
                UI.head50.GetComponent<Button>().interactable = true;
                UI.head10.GetComponent<Button>().interactable = true;
                UI.head5.GetComponent<Button>().interactable = true;
                UI.head1.GetComponent<Button>().interactable = true;

                UI.endMax.GetComponent<Button>().interactable = true;
                UI.end500.GetComponent<Button>().interactable = true;
                UI.end100.GetComponent<Button>().interactable = true;
                UI.end50.GetComponent<Button>().interactable = true;
                UI.end10.GetComponent<Button>().interactable = true;
                UI.end5.GetComponent<Button>().interactable = true;
                UI.end1.GetComponent<Button>().interactable = true;
            }
            else if (!__instance.selectedRecipe.Handcraft)
            {
                UI.headMax.GetComponent<Button>().interactable = false;
                UI.head500.GetComponent<Button>().interactable = false;
                UI.head100.GetComponent<Button>().interactable = false;
                UI.head50.GetComponent<Button>().interactable = false;
                UI.head10.GetComponent<Button>().interactable = false;
                UI.head5.GetComponent<Button>().interactable = false;
                UI.head1.GetComponent<Button>().interactable = false;

                UI.endMax.GetComponent<Button>().interactable = false;
                UI.end500.GetComponent<Button>().interactable = false;
                UI.end100.GetComponent<Button>().interactable = false;
                UI.end50.GetComponent<Button>().interactable = false;
                UI.end10.GetComponent<Button>().interactable = false;
                UI.end5.GetComponent<Button>().interactable = false;
                UI.end1.GetComponent<Button>().interactable = false;
            }
            else if (__instance.selectedRecipe != null)
            {
                int num = __instance.mechaForge.PredictTaskCount(__instance.selectedRecipe.ID, 999, false);

                UI.headMax.GetComponent<Button>().interactable = (num > 0);
                UI.head500.GetComponent<Button>().interactable = (num >= 500); ;
                UI.head100.GetComponent<Button>().interactable = (num >= 100);
                UI.head50.GetComponent<Button>().interactable = (num >= 50);
                UI.head10.GetComponent<Button>().interactable = (num >= 10);
                UI.head5.GetComponent<Button>().interactable = (num >= 5);
                UI.head1.GetComponent<Button>().interactable = (num >= 1);

                UI.endMax.GetComponent<Button>().interactable = (num > 0);
                UI.end500.GetComponent<Button>().interactable = (num >= 500);
                UI.end100.GetComponent<Button>().interactable = (num >= 100);
                UI.end50.GetComponent<Button>().interactable = (num >= 50);
                UI.end10.GetComponent<Button>().interactable = (num >= 10);
                UI.end5.GetComponent<Button>().interactable = (num >= 5);
                UI.end1.GetComponent<Button>().interactable = (num >= 1);
            }
        }

        //前回開いていたレシピを表示する
        [HarmonyPostfix, HarmonyPatch(typeof(UIReplicatorWindow), "OnRecipeMouseDown")]
        public static void UIReplicatorWindow_SetSelectedRecipeIndex_Postfix(UIReplicatorWindow __instance)
        {
            SelectedRecipeIndexBk = __instance.mouseRecipeIndex;
            currentTypeBk = __instance.currentType;
            resipeBk = __instance.selectedRecipe;
        }


        [HarmonyPostfix, HarmonyPatch(typeof(UIReplicatorWindow), "_OnOpen")]
        public static void UIReplicatorWindow_OnOpen_Postfix(UIReplicatorWindow __instance)
        {
            __instance.selectedRecipe = resipeBk;
            __instance.currentType = currentTypeBk;
            __instance.RefreshRecipeIcons();
            __instance.typeButton1.highlighted = (currentTypeBk == 1);
            __instance.typeButton2.highlighted = (currentTypeBk == 2);
            __instance.typeButton1.button.interactable = (currentTypeBk != 1);
            __instance.typeButton2.button.interactable = (currentTypeBk != 2);
            __instance.SetSelectedRecipeIndex(SelectedRecipeIndexBk, true);
            __instance.OnSelectedRecipeChange(true);

        }
    }

}
