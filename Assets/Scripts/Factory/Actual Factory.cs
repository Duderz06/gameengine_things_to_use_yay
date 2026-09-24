using UnityEngine;
using static FactoryBase;

public class ActualFactory : MonoBehaviour
{

    public enum FactoryBase { Thingy1, Thingy2 }


    public GameObject Thing1Obj;
    public GameObject Thing2Obj;



    public FactoryBase DoTheThing(FactoryBase type, Vector3 position)
    {

        GameObject obj = type switch
        {
            FactoryBase.Thingy1 => Instantiate(Thing1Obj, position, Quaternion.identity),

            FactoryBase.Thingy2 => Instantiate(Thing2Obj, position, Quaternion.identity),

            _ => throw new System.ArgumentException("incorrect sound buzzer sfx")

        };


        FactoryBase thing = obj.GetComponent<FactoryBase>();


        //thing.Test1();


        return thing;


    }


}
