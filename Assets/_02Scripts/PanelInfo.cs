using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelInfo : PanelBase
{
    private Button btClose;

    public override void Init(params object[] args)
    {
        base.Init(args);
        skinPath = "PanelInfo";
        layer = PanelLayer.Panel;
    }

    public override void OnShowing()
    {
        base.OnShowing();
        Transform skinTrans = skin.transform;
        btClose = skinTrans.FindChild("BtClose").GetComponent<Button>();
        btClose.onClick.AddListener(OnCloseClick);
    }

    public void OnCloseClick()
    {
        Close();
    }
}
