using UnityEngine;
using System.Collections;

public class Root : MonoBehaviour
{
    private void Start()
    {
        PanelMgr.instance.OpenPanel<PanelTitle>("");
    }

    private void Update()
    {
        //仅用于点击开始游戏之后测试使用
        if (Input.GetKeyDown(KeyCode.W))
        {
            PanelMgr.instance.OpenPanel<PanelWin>("", 1);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            PanelMgr.instance.OpenPanel<PanelWin>("", 0);
        }
    }
}
