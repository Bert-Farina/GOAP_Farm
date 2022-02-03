using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanPoop : GAction
{
    public override bool PrePerform()
    {
        target = GWorld.Instance.RemovePoop();
        if (target == null)
            return false;
        inventory.AddItem(target);
        GWorld.Instance.GetWorld().ModifyState("uncleanPoop", -1);
        return true;
    }

    public override bool PostPerform()
    {
        inventory.RemoveItem(target);
        Destroy(target);
        beliefs.ModifyState("leaveRest", 0);
        return true;
    }
}
