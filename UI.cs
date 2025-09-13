using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace DSPReplicatorPlus
{

    internal class UI : MonoBehaviour
    {
        public static GameObject headTitle = new GameObject();
        public static GameObject headMax = new GameObject();
        public static GameObject head500 = new GameObject();
        public static GameObject head100 = new GameObject();
        public static GameObject head50 = new GameObject();
        public static GameObject head10 = new GameObject();
        public static GameObject head5 = new GameObject();
        public static GameObject head1 = new GameObject();
        public static GameObject endTitle = new GameObject();
        public static GameObject endMax = new GameObject();
        public static GameObject end500 = new GameObject();
        public static GameObject end100 = new GameObject();
        public static GameObject end50 = new GameObject();
        public static GameObject end10 = new GameObject();
        public static GameObject end5 = new GameObject();
        public static GameObject end1 = new GameObject();

        public static float headX = -60;
        public static float headY = 160;
        public static float diffX = 120;
        public static float diffY = 22;

        public static void Create()
        {
            //ボタンの作成
            GameObject multiValueText = UIRoot.instance.uiGame.replicator.multiValueText.gameObject;
            headTitle = Instantiate(multiValueText, multiValueText.transform.parent);
            headTitle.transform.localPosition = new Vector3(headX, headY + diffY, 0);
            headTitle.GetComponent<Text>().text = "to head".Translate();

            GameObject minusButton = UIRoot.instance.uiGame.replicator.minusButton.gameObject;

            headMax = Instantiate(minusButton, minusButton.transform.parent);
            headMax.GetComponent<RectTransform>().sizeDelta = new Vector2(40, 24);
            headMax.transform.localPosition = new Vector3(headX, headY, 0);
            headMax.transform.Find("text").GetComponent<Text>().text = "MAX".Translate();
            headMax.transform.Find("text").GetComponent<Text>().font = headTitle.GetComponent<Text>().font;
            headMax.transform.Find("text").GetComponent<Text>().fontSize = 16;

            head500 = Instantiate(headMax, headMax.transform.parent);
            head500.transform.localPosition = new Vector3(headX, headY - diffY * 1, 0);
            head500.transform.Find("text").GetComponent<Text>().text = "500";

            head100 = Instantiate(headMax, headMax.transform.parent);
            head100.transform.localPosition = new Vector3(headX, headY - diffY * 2, 0);
            head100.transform.Find("text").GetComponent<Text>().text = "100";

            head50 = Instantiate(headMax, headMax.transform.parent);
            head50.transform.localPosition = new Vector3(headX, headY - diffY * 3, 0);
            head50.transform.Find("text").GetComponent<Text>().text = "50";

            head10 = Instantiate(headMax, headMax.transform.parent);
            head10.transform.localPosition = new Vector3(headX, headY - diffY * 4, 0);
            head10.transform.Find("text").GetComponent<Text>().text = "10";

            head5 = Instantiate(headMax, headMax.transform.parent);
            head5.transform.localPosition = new Vector3(headX, headY - diffY * 5, 0);
            head5.transform.Find("text").GetComponent<Text>().text = "5";

            head1 = Instantiate(headMax, headMax.transform.parent);
            head1.transform.localPosition = new Vector3(headX, headY - diffY * 6, 0);
            head1.transform.Find("text").GetComponent<Text>().text = "1";

            GameObject plusButton = UIRoot.instance.uiGame.replicator.plusButton.gameObject;

            endTitle = Instantiate(multiValueText, multiValueText.transform.parent);
            endTitle.transform.localPosition = new Vector3(headX + diffX, headY + diffY, 0);
            endTitle.GetComponent<Text>().text = "to end".Translate();

            endMax = Instantiate(plusButton, plusButton.transform.parent);
            endMax.GetComponent<RectTransform>().sizeDelta = new Vector2(40, 24);
            endMax.transform.localPosition = new Vector3(headX + diffX, headY, 0);
            endMax.transform.Find("text").transform.localPosition = new Vector3(-1, 1, 0);
            endMax.transform.Find("text").GetComponent<Text>().text = "MAX".Translate();
            endMax.transform.Find("text").GetComponent<Text>().font = headTitle.GetComponent<Text>().font;
            endMax.transform.Find("text").GetComponent<Text>().fontSize = 16;

            end500 = Instantiate(endMax, endMax.transform.parent);
            end500.transform.localPosition = new Vector3(headX + diffX, headY - diffY * 1, 0);
            end500.transform.Find("text").transform.localPosition = new Vector3(-1, 1, 0);
            end500.transform.Find("text").GetComponent<Text>().text = "500";

            end100 = Instantiate(endMax, endMax.transform.parent);
            end100.transform.localPosition = new Vector3(headX + diffX, headY - diffY * 2, 0);
            end100.transform.Find("text").transform.localPosition = new Vector3(-1, 1, 0);
            end100.transform.Find("text").GetComponent<Text>().text = "100";

            end50 = Instantiate(endMax, endMax.transform.parent);
            end50.transform.localPosition = new Vector3(headX + diffX, headY - diffY * 3, 0);
            end50.transform.Find("text").transform.localPosition = new Vector3(-1, 1, 0);
            end50.transform.Find("text").GetComponent<Text>().text = "50";

            end10 = Instantiate(endMax, endMax.transform.parent);
            end10.transform.localPosition = new Vector3(headX + diffX, headY - diffY * 4, 0);
            end10.transform.Find("text").transform.localPosition = new Vector3(-1, 1, 0);
            end10.transform.Find("text").GetComponent<Text>().text = "10";

            end5 = Instantiate(endMax, endMax.transform.parent);
            end5.transform.localPosition = new Vector3(headX + diffX, headY - diffY * 5, 0);
            end5.transform.Find("text").transform.localPosition = new Vector3(-1, 1, 0);
            end5.transform.Find("text").GetComponent<Text>().text = "5";

            end1 = Instantiate(endMax, endMax.transform.parent);
            end1.transform.localPosition = new Vector3(headX + diffX, headY - diffY * 6, 0);
            end1.transform.Find("text").transform.localPosition = new Vector3(-1, 1, 0);
            end1.transform.Find("text").GetComponent<Text>().text = "1";

            //okボタンの改変
            GameObject okButton = UIRoot.instance.uiGame.replicator.transform.Find("recipe-tree/ok-btn").gameObject;
            okButton.transform.localPosition = new Vector3(349, 120, 0); //349 130 0
            //okButton.GetComponent<Image>().enabled = false;
            okButton.transform.Find("img").GetComponent<Image>().enabled = false;
            GameObject predCount = okButton.transform.Find("pred-count").gameObject;
            predCount.transform.localPosition = new Vector3(0, 71, 0); //38 44 0

            ////カウントの位置調整
            GameObject count = UIRoot.instance.uiGame.replicator.transform.Find("recipe-tree/count").gameObject;
            count.transform.localPosition = new Vector3(349, 30, 0);


            //イベント
            headMax.GetComponent<Button>().onClick.AddListener(OnClickHeadMax);
            head500.GetComponent<Button>().onClick.AddListener(OnClickHead500);
            head100.GetComponent<Button>().onClick.AddListener(OnClickHead100);
            head50.GetComponent<Button>().onClick.AddListener(OnClickHead50);
            head10.GetComponent<Button>().onClick.AddListener(OnClickHead10);
            head5.GetComponent<Button>().onClick.AddListener(OnClickHead5);
            head1.GetComponent<Button>().onClick.AddListener(OnClickHead1);
            endMax.GetComponent<Button>().onClick.AddListener(OnClickEndMax);
            end500.GetComponent<Button>().onClick.AddListener(OnClickEnd500);
            end100.GetComponent<Button>().onClick.AddListener(OnClickEnd100);
            end50.GetComponent<Button>().onClick.AddListener(OnClickEnd50);
            end10.GetComponent<Button>().onClick.AddListener(OnClickEnd10);
            end5.GetComponent<Button>().onClick.AddListener(OnClickEnd5);
            end1.GetComponent<Button>().onClick.AddListener(OnClickEnd1);
        }

        public static void OnClickEndMax()
        {
            UIReplicatorWindow replicator = UIRoot.instance.uiGame.replicator;
            if (replicator.isInstantItem)
            {
                MechaForgeAddTask(1000);
            }
            else
            {
                MechaForgeAddTask(replicator.mechaForge.PredictTaskCount(replicator.selectedRecipe.ID, 999));
            }
        }

        public static void OnClickEnd500()
        {
            MechaForgeAddTask(500);
        }
        public static void OnClickEnd100()
        {
            MechaForgeAddTask(100);
        }
        public static void OnClickEnd50()
        {
            MechaForgeAddTask(50);
        }
        public static void OnClickEnd10()
        {
            MechaForgeAddTask(10);
        }
        public static void OnClickEnd5()
        {
            MechaForgeAddTask(5);
        }
        public static void OnClickEnd1()
        {
            MechaForgeAddTask(1);
        }

        public static void OnClickHeadMax()
        {
            UIReplicatorWindow replicator = UIRoot.instance.uiGame.replicator;
            if(replicator.isInstantItem)
            {
                MechaForgeAddTaskHead(1000);
            }
            else
            {
                MechaForgeAddTaskHead(replicator.mechaForge.PredictTaskCount(replicator.selectedRecipe.ID, 999));
            }
        }

        public static void OnClickHead500()
        {
            MechaForgeAddTaskHead(500);
        }
        public static void OnClickHead100()
        {
            MechaForgeAddTaskHead(100);
        }
        public static void OnClickHead50()
        {
            MechaForgeAddTaskHead(50);
        }
        public static void OnClickHead10()
        {
            MechaForgeAddTaskHead(10);
        }
        public static void OnClickHead5()
        {
            MechaForgeAddTaskHead(5);
        }
        public static void OnClickHead1()
        {
            MechaForgeAddTaskHead(1);
        }

        public static void MechaForgeAddTask(int count)
        {
            UIReplicatorWindow replicator = UIRoot.instance.uiGame.replicator;
            int id = replicator.selectedRecipe.ID;
            replicator.mechaForge.AddTask(id, count);
        }

        public static void MechaForgeAddTaskHead(int count)
        {
            UIReplicatorWindow replicator = UIRoot.instance.uiGame.replicator;
            int id = replicator.selectedRecipe.ID;
            int length = replicator.mechaForge.tasks.Count;
            if (length == 0)
            {
                replicator.mechaForge.AddTask(id, count);
            }
            else
            {
                List<ForgeTask> list = new List<ForgeTask>(replicator.mechaForge.tasks);
                replicator.mechaForge.tasks.Clear();
                replicator.mechaForge.AddTask(id, count);
                int incr = replicator.mechaForge.tasks.Count;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].parentTaskIndex >= 0)
                    {
                        list[i].parentTaskIndex += incr;
                    }
                    replicator.mechaForge.tasks.Add(list[i]);
                }
            }
        }
    }
}