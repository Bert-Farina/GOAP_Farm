using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDrink : GAction
{
    public override bool PrePerform()
    {
        if (!GWorld.Instance.GetWorld().HasState("bigAnimalWater"))
        {
            return false;
        }
        return true;
    }

    public override bool PostPerform()
    {
        beliefs.RemoveState("isThirsty");
        GWorld.Instance.GetWorld().ModifyState("bigAnimalWater", -1);
        if (!GWorld.Instance.GetWorld().HasState("bigAnimalWater"))
        {
            GWorld.Instance.AddDrinker(GameObject.Find("BigAnimalWater"));
            GWorld.Instance.GetWorld().ModifyState("emptyWater", 1);
        }
        return true;
    }
}
