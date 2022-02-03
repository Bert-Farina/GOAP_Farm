using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : GAction
{
    private GameObject targetWander;

    new private void Awake() 
    {
        base.Awake();
        targetWander = target;
    }

    public override bool PrePerform()
    {
        Vector3 offset = new Vector3(Random.Range(-5.0f, 5.0f), 0f, Random.Range(-5.0f, 5.0f));
        if(offset.x + targetWander.transform.position.x < 29f && offset.x + targetWander.transform.position.x > -29f && offset.z + targetWander.transform.position.z >  -45f && offset.z + targetWander.transform.position.z < 48.5f)
        {
            targetWander.transform.position += offset;
        }
        target = targetWander;

        if (target == null)
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
