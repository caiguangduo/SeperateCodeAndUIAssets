using UnityEngine;
using System.Collections;

public class PanelBase : MonoBehaviour
{
    public string skinPath;
    public GameObject skin;
    public PanelLayer layer;
    public object[] args;

    public virtual void Init(params object[] args)
    {
        this.args = args;
    }

    public virtual void OnShowing() { }
    public virtual void OnShowed() { }
    public virtual void Update() { }
    public virtual void OnClosing() { }
    public virtual void OnClosed() { }

    protected virtual void Close()
    {
        string name = this.GetType().ToString();
        PanelMgr.instance.ClosePanel(name);
    }
}
