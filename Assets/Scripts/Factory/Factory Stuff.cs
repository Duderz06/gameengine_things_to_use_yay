using UnityEngine;


public class Thingy1 : FactoryBase, FactoryBase.IFactoryThing
{

    public void Test1() => Debug.Log("test 1 thing 1");
    public void Test2() => Debug.Log("test 2 thing 1");

}



public class Thingy2 : FactoryBase, FactoryBase.IFactoryThing
{

    public void Test1() => Debug.Log("test 1 thing 2");
    public void Test2() => Debug.Log("test 2 thing 2");

}