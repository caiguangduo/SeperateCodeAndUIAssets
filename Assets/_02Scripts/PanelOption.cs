using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelOption : PanelBase
{
    private Button btStart;
    private Button btClose;
    private Dropdown dropDown1;
    private Dropdown dropDown2;

    public override void Init(params object[] args)
    {
        base.Init(args);
        skinPath = "PanelOption";
        layer = PanelLayer.Panel;
    }

    public override void OnShowing()
    {
        base.OnShowing();
        Transform skinTrans = skin.transform;
        btStart = skinTrans.FindChild("BtStart").GetComponent<Button>();
        btStart.onClick.AddListener(OnStartClick);

        btClose = skinTrans.FindChild("BtClose").GetComponent<Button>();
        btClose.onClick.AddListener(OnCloseClick);

        dropDown1 = skinTrans.FindChild("Dropdown01").GetComponent<Dropdown>();
        dropDown2 = skinTrans.FindChild("Dropdown02").GetComponent<Dropdown>();
    }

    public void OnStartClick()
    {
        PanelMgr.instance.ClosePanel("PanelTitle");
        int n1 = dropDown1.value + 1;
        int n2 = dropDown2.value + 1;
        //开始战斗
        Close();
    }
    public void OnCloseClick()
    {
        Close();
    }
}
