using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillFood : GAction
{
    public override bool PrePerform()
    {
        target = GWorld.Instance.RemoveEater();
        if (target == null)
            return false;
        inventory.AddItem(target);
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.fillBigAnimalFood();
        beliefs.ModifyState("leaveRest", 0);
        return true;
    }
}
