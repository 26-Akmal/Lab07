using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float score;
    public Text ScoreUI;
    // Start is called before the first frame update
    void Start()
    {
        ScoreUI.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreUI.text = "Score: " + score;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Death")
        {
            score += 10;
        }
    }
}
