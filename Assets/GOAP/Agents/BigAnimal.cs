using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigAnimal : GAgent
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();

        SubGoal s1 = new SubGoal("hasEaten", 1, false);
        goals.Add(s1, 2);
        Invoke("NeedsToEat", Random.Range(30, 40));

        SubGoal s2 = new SubGoal("hasDrunk", 1, false);
        goals.Add(s2, 2);
        Invoke("NeedsToDrink", Random.Range(15, 25));

        SubGoal s3 = new SubGoal("Wander", 1, false);
        goals.Add(s3, 1);

        SubGoal s4 = new SubGoal("hasSleep", 1, false);
        goals.Add(s4, 5);

        SubGoal s5 = new SubGoal("hasPooped", 1, false);
        goals.Add(s5, 3);
        Invoke("NeedsToPoop", Random.Range(60,90));
    }

    void NeedsToEat()
    {
        beliefs.ModifyState("isHungry", 0);
        Invoke("NeedsToEat", Random.Range(30, 40));
    }

    void NeedsToDrink()
    {
        beliefs.ModifyState("isThirsty", 0);
        Invoke("NeedsToDrink", Random.Range(15, 25));
    }

    void NeedsToPoop()
    {
        beliefs.ModifyState("hasPoop", 0);
        Invoke("NeedsToPoop", Random.Range(60,90));
    }
}
