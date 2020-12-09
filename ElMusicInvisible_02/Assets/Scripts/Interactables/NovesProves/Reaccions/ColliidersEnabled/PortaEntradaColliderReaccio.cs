using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaEntradaColliderReaccio : Reaccio
{
    public PortaEntradaCollider entradaCollider;
    public bool enable;

    protected override void ExecutaReaccio()
    {
        entradaCollider.SetEnabled(enable); 
    }

    
}
