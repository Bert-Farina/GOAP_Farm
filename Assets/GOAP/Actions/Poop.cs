using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : GAction
{
    public GameObject poopPrefab;

    public override bool PrePerform()
    {
        target = this.gameObject;
        if (target == null)
            return false;
        return true;
    }

    public override bool PostPerform()
    {
        Vector3 location = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        GameObject poop = Instantiate(poopPrefab, location, poopPrefab.transform.rotation);
        GWorld.Instance.AddPoop(poop);
        GWorld.Instance.GetWorld().ModifyState("uncleanPoop", 1);
        beliefs.RemoveState("hasPoop");
        return true;
    }
}
