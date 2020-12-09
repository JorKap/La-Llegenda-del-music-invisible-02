using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaEscalaReaccio : Reaccio
{
    public PortaEscala portaEscala;
    public int index;
    protected override void ExecutaReaccio()
    {
        portaEscala.SaveIndex(index);
    }
}
