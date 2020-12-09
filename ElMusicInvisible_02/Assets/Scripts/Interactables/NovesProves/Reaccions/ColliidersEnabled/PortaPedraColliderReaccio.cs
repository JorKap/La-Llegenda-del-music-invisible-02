using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaPedraColliderReaccio : Reaccio
{

    public PortaPedraCollider portaPedraCollider;
    public bool enable;

    protected override void ExecutaReaccio()
    {
        portaPedraCollider.SetEnabled(enable);
    }


}
