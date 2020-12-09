using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaSalaPianoReaccio : Reaccio
{
    public PortaSalaPiano salaPiano;
    public int index;
    protected override void ExecutaReaccio()
    {
        salaPiano.SaveIndex(index);
    }
}
