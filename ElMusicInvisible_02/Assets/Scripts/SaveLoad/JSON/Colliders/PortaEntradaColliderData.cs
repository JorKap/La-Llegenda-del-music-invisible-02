using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PortaEntradaColliderData 
{
    public bool enable;

    public PortaEntradaColliderData(PortaEntradaCollider portaEntradaCollider)
    {
        enable = portaEntradaCollider.enable;
    }
}
