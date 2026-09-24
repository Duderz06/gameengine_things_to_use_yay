using UnityEngine;

public class GamePauseStuff : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {

            bool paused = GameManagerTest.Instance.GetPaused();

            if (paused) {

                Debug.Log("unpause");

                GameManagerTest.Instance.SetPause(false);

            }

            else {

                Debug.Log("start pause");
                GameManagerTest.Instance.SetPause(true);

            }



        }
    }
}
