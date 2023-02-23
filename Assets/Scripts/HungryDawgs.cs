using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungryDawgs : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider hungerSlider;
    public int steakCapacity;

    private int steakEaten = 0;
    void Start()
    {
      hungerSlider.maxValue = steakCapacity;
      hungerSlider.value = 0;
      ActivateSlider(active: false);

      scoreBoard = GameObject.Find("ScoreBoard").GetComponent<ScoreBoard>();
    }
    private ScoreBoard scoreBoard;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FeedDawg(int amount) {
      steakEaten += 1;
      ActivateSlider(active: true);
      hungerSlider.value = steakEaten;
      scoreBoard.UpdateScore(value: 1);
      if (steakEaten >= steakCapacity) {
        Destroy(gameObject);
      }
    }
    public void ActivateSlider(bool active) {
      hungerSlider.fillRect.gameObject.SetActive(active);
    }
}
