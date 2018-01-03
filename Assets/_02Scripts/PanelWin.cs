using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelWin : PanelBase
{
    private Image imageWin;
    private Image imageFail;
    private Button btClose;
    private bool isWin;

    public override void Init(params object[] args)
    {
        base.Init(args);
        skinPath = "PanelWin";
        layer = PanelLayer.Panel;
        if (args.Length == 1)
        {
            int camp = (int)args[0];
            isWin = (camp == 1);
        }
    }

    public override void OnShowing()
    {
        base.OnShowing();
        Transform skinTrans = skin.transform;
        btClose = skinTrans.FindChild("BtClose").GetComponent<Button>();
        btClose.onClick.AddListener(OnCloseClick);

        imageWin = skinTrans.FindChild("ImageWin").GetComponent<Image>();
        imageFail = skinTrans.FindChild("ImageFail").GetComponent<Image>();

        if (isWin)
        {
            imageFail.enabled = false;
        }
        else
        {
            imageWin.enabled = false;
        }
    }

    public void OnCloseClick()
    {
        //结束战斗
        PanelMgr.instance.OpenPanel<PanelTitle>("");
        Close();
    }
}
