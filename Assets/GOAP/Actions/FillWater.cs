using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillWater : GAction
{
    public override bool PrePerform()
    {
        target = GWorld.Instance.RemoveDrinker();
        if (target == null)
            return false;
        inventory.AddItem(target);
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.fillBigAnimalWater();
        beliefs.ModifyState("leaveRest", 0);
        return true;
    }
}
