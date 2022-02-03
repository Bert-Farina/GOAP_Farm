using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GWorld
{
    private static readonly GWorld instance = new GWorld();
    private static WorldStates world;
    private static Queue<GameObject> poops;
    private static Queue<GameObject> eatersToFill;
    private static Queue<GameObject> drinkersToFill;
    private static int maxCapacityBig = 7;
    private static int maxCapacitySmall = 3;

    static GWorld()
    {
        world = new WorldStates();

        poops = new Queue<GameObject>();
        eatersToFill = new Queue<GameObject>();
        drinkersToFill = new Queue<GameObject>();

        world.ModifyState("bigAnimalFood", maxCapacityBig);
        world.ModifyState("chickenFood", maxCapacitySmall);
        world.ModifyState("bigAnimalWater", maxCapacityBig);
        world.ModifyState("chickenWater", maxCapacitySmall);

        Time.timeScale = 5;
    }

    private GWorld()
    {
    }

    public void fillBigAnimalFood()
    {
        world.ModifyState("bigAnimalFood", maxCapacityBig);
    }

    public void fillBigAnimalWater()
    {
        world.ModifyState("bigAnimalWater", maxCapacityBig);
    }

    public void fillChickenFood()
    {
        world.ModifyState("chickenFood", maxCapacitySmall);
    }

    public void fillChickenWater()
    {
        world.ModifyState("chickenWater", maxCapacitySmall);
    }

    public void AddPoop(GameObject p)
    {
        poops.Enqueue(p);
    }

    public GameObject RemovePoop()
    {
        if (poops.Count == 0) return null;
        return poops.Dequeue();
    }

    public void AddEater(GameObject p)
    {
        eatersToFill.Enqueue(p);
    }

    public GameObject RemoveEater()
    {
        if (eatersToFill.Count == 0) return null;
        return eatersToFill.Dequeue();
    }

    public void AddDrinker(GameObject p)
    {
        drinkersToFill.Enqueue(p);
    }

    public GameObject RemoveDrinker()
    {
        if (drinkersToFill.Count == 0) return null;
        return drinkersToFill.Dequeue();
    }

    public static GWorld Instance
    {
        get { return instance; }
    }

    public WorldStates GetWorld()
    {
        return world;
    }
}
