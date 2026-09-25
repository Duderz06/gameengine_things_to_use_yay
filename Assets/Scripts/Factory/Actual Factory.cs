using UnityEngine;
using static FactoryBase;

public class ActualFactory : MonoBehaviour
{

    public enum FactoryType{Thingy1, Thingy2}

    public GameObject Thing1Obj;
    public GameObject Thing2Obj;



    public FactoryBase.IFactoryThing DoTheThing(FactoryType type, Vector3 position)
    {



        GameObject obj = type switch
        {
            FactoryType.Thingy1 => Instantiate(Thing1Obj, position, Quaternion.identity),

            FactoryType.Thingy2 => Instantiate(Thing2Obj, position, Quaternion.identity),

            _ => throw new System.ArgumentException("Incorrect factory type")

        };



        FactoryBase.IFactoryThing thing = obj.GetComponent<FactoryBase.IFactoryThing>();

        thing.Test1();

        return thing;

    }


}
