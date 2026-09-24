using UnityEngine;

public class PlayerStuff : MonoBehaviour
{

    public GameObject Player;
    public Transform PlayerStart;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManagerTest.Instance.SetPlayerObj(Player);
        GameManagerTest.Instance.SetPlayerStart(PlayerStart);
        GameManagerTest.Instance.SpawnPlayer();




    }

    
    
}
