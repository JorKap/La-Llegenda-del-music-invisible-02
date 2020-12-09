using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PortaPedraColliderData 
{
    public bool enable;

    public PortaPedraColliderData(PortaPedraCollider portaPedraCollider)
    {
        enable = portaPedraCollider.enable;
    }
}
