using UnityEngine;

public class GameManagerTest : MonoBehaviour
{


    public static GameManagerTest Instance { get; private set; }


    public static bool PlayerAlive = true;
    public static bool PlayerPaused = false;

    public static int CurrentLevel = 1;
    public static GameObject Player;
    public static Transform PlayerStart;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);
    }


    public bool GetPaused()
    {


        return PlayerPaused;

    }

    public void SetPause(bool NewPause)
    {

        PlayerPaused = NewPause;



    }


    public int GetCurrentLevel() { 
    
        return CurrentLevel;
    
    }


    public void SetPlayerObj(GameObject NewPlayer) {

        Player = NewPlayer;



    }


    public void SetPlayerStart(Transform StartPos)
    {

        PlayerStart = StartPos;



    }



    public void SpawnPlayer() { 
    
        Instantiate(Player,PlayerStart.position,PlayerStart.rotation);
    
    
    }


}
