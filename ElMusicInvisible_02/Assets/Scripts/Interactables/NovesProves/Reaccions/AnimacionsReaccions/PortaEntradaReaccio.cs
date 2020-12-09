using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaEntradaReaccio : Reaccio
{
    public PortaEntradaGobj portaEntradaGobj;
    public int index;
    protected override void ExecutaReaccio()
    {
        portaEntradaGobj.SaveIndex(index);
    }
}
