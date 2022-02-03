using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : GAgent
{
    GameObject sun;

    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        sun = GameObject.Find("Sun");
        Invoke("SunDown", 120);

        SubGoal s1 = new SubGoal("clean", 1, false);
        goals.Add(s1, 2);

        SubGoal s2 = new SubGoal("refillFood", 1, false);
        goals.Add(s2, 3);

        SubGoal s3 = new SubGoal("refillWater", 1, false);
        goals.Add(s3, 3);

        /*SubGoal s4 = new SubGoal("fillChickenFood", 1, false);
        goals.Add(s4, 5);

        SubGoal s5 = new SubGoal("fillChickenDrink", 1, false);
        goals.Add(s5, 5);*/

        SubGoal s6 = new SubGoal("Rest", 1, false);
        goals.Add(s6, 1);
    }

    void SunDown()
    {
        sun.SetActive(false);
        GWorld.Instance.GetWorld().ModifyState("isNight", 0);
        Invoke("SunUp", 60);
    }

    void SunUp()
    {
        sun.SetActive(true);
        GWorld.Instance.GetWorld().RemoveState("isNight");
        Invoke("SunDown", 120);
    }
}
