using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoSleep : GAction
{
    public override bool PrePerform()
    {
        if (!GWorld.Instance.GetWorld().HasState("isNight"))
        {
            return false;
        }
        return true;
    }

    public override bool PostPerform()
    {
        return true;
    }
}
