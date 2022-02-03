using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToRest : GAction
{
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        beliefs.RemoveState("leaveRest");
        return true;
    }
}
