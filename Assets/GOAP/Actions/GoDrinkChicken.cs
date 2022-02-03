using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDrinkChicken : GAction
{
    public override bool PrePerform()
    {
        if (!GWorld.Instance.GetWorld().HasState("chickenWater"))
        {
            return false;
        }
        return true;
    }

    public override bool PostPerform()
    {
        beliefs.RemoveState("isThirsty");
        GWorld.Instance.GetWorld().ModifyState("chickenWater", -1);
        if (!GWorld.Instance.GetWorld().HasState("chickenWater"))
        {
            GWorld.Instance.AddDrinker(GameObject.Find("ChickenWater"));
            GWorld.Instance.GetWorld().ModifyState("emptyWater", 1);
        }
        return true;
    }
}
