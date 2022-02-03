using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoEat : GAction
{
    public override bool PrePerform()
    {
        if (GWorld.Instance.GetWorld().HasState("bigAnimalFood"))
        {
            return true;
        }
        return false;
    }

    public override bool PostPerform()
    {
        beliefs.RemoveState("isHungry");
        GWorld.Instance.GetWorld().ModifyState("bigAnimalFood", -1);
        if (!GWorld.Instance.GetWorld().HasState("bigAnimalFood"))
        {
            GWorld.Instance.AddEater(GameObject.Find("BigAnimalFood"));
            GWorld.Instance.GetWorld().ModifyState("emptyFood", 1);
        }
        return true;
    }
}
