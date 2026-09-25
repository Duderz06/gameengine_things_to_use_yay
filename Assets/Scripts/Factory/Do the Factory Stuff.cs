using UnityEngine;

public class DotheFactoryStuff : MonoBehaviour
{

    public ActualFactory Factory;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Factory.DoTheThing(ActualFactory.FactoryType.Thingy1, transform.position);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Factory.DoTheThing(ActualFactory.FactoryType.Thingy2, transform.position);
        }


    }

}