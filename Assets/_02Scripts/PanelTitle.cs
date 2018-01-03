using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelTitle : PanelBase
{
    private Button btStart;
    private Button btInfo;

    public override void Init(params object[] args)
    {
        base.Init(args);
        skinPath = "PanelTitle";
        layer = PanelLayer.Panel;
    }

    public override void OnShowing()
    {
        base.OnShowing();
        Transform skinTrans = skin.transform;
        btStart = skinTrans.FindChild("BtStart").GetComponent<Button>();
        btInfo = skinTrans.FindChild("BtInfo").GetComponent<Button>();

        btStart.onClick.AddListener(OnStartClick);
        btInfo.onClick.AddListener(OnInfoClick);
    }

    public void OnStartClick()
    {
        PanelMgr.instance.OpenPanel<PanelOption>("");
    }
    public void OnInfoClick()
    {
        PanelMgr.instance.OpenPanel<PanelInfo>("");
    }
}
