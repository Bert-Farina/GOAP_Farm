using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoEatChicken : GAction
{
    public override bool PrePerform()
    {
        if (GWorld.Instance.GetWorld().HasState("chickenFood"))
        {
            return true;
        }
        return false;
    }

    public override bool PostPerform()
    {
        beliefs.RemoveState("isHungry");
        GWorld.Instance.GetWorld().ModifyState("chickenFood", -1);
        if (!GWorld.Instance.GetWorld().HasState("chickenFood"))
        {
            GWorld.Instance.AddEater(GameObject.Find("ChickenFood"));
            GWorld.Instance.GetWorld().ModifyState("emptyFood", 1);
        }
        return true;
    }
}
