using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaPedraCollider : MonoBehaviour
{
    public bool enable;
    public Collider col;
    // Start is called before the first frame update


    public void SetEnabled(bool enable)
    {
        this.enable = enable;
    }

    public void EraseJson()
    {
        SavePortaPedraCollider.Save(this);
    }

    private void OnDisable()
    {
        SavePortaPedraCollider.Save(this);
    }

    private void OnEnable()
    {
        PortaPedraColliderData data = SavePortaPedraCollider.Load();

        enable = data.enable;
        col.enabled = enable;
    }
}
