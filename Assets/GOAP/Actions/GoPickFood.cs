using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoPickFood : GAction
{
    public override bool PrePerform()
    {
        if (GWorld.Instance.GetWorld().HasState("emptyFood"))
        {
            GWorld.Instance.GetWorld().ModifyState("emptyFood", -1);
            return true;
        }
        return false;
    }

    public override bool PostPerform()
    {
        return true;
    }
}
