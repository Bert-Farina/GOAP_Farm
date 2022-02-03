using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToLake : GAction
{
    public override bool PrePerform()
    {
        if (GWorld.Instance.GetWorld().HasState("emptyWater"))
        {
            GWorld.Instance.GetWorld().ModifyState("emptyWater", -1);
            return true;
        }
        return false;
    }

    public override bool PostPerform()
    {
        return true;
    }
}
