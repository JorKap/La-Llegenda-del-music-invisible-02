using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaPedraVestibulReaccio : Reaccio
{
    public PortaPedraGObj portaPedraGobj;
    public int index;
    public bool setActive;
    protected override void ExecutaReaccio()
    {
        portaPedraGobj.SaveIndex(index);
        portaPedraGobj.SaveBool(setActive);
    }

}
