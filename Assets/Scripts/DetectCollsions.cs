using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollsions : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Start()
    {
      scoreBoard = GameObject.Find("ScoreBoard").GetComponent<ScoreBoard>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private ScoreBoard scoreBoard;
    private void OnTriggerEnter(Collider other) {
      if (gameObject.name.Contains("Food_Steak_01") && other.gameObject.name.Contains("Player") || 
      other.gameObject.name.Contains("Food_Steak_01") && gameObject.name.Contains("Player")){
        Debug.Log("Steaks Away!");
      } else if (other.gameObject.name.Contains("Dog") && gameObject.name.Contains("Player")) {
        scoreBoard.UpdateLives(-1);
        Debug.Log($"Hit! {scoreBoard.lives} Lives Left!");
        if (scoreBoard.lives < 1) {
          Destroy(gameObject);
          Debug.Log($"Game Over!!! Score: {scoreBoard.score}");
        }
      } else if (gameObject.name.Contains("Dog") && other.gameObject.name.Contains("Food_Steak_01")) {
          gameObject.GetComponent<HungryDawgs>().FeedDawg(1);
          Destroy(other.gameObject);
          Debug.Log($"Score: {scoreBoard.score}");
        }
    }
}
