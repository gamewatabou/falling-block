using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    // スコア表示のオブジェクト
    public GameObject now_score_object;
    public GameObject high_score_object;

    // Start is called before the first frame update
    void Start()
    {
        // スコアの表示
        int now_score = PlayerPrefs.GetInt("NOW_SCORE", 0);
        Text now_score_text = now_score_object.GetComponent<Text>();
        now_score_text.text = "Score:" + now_score;

        // ハイスコアの表示
        int high_score = PlayerPrefs.GetInt("HIGH_SCORE", 0);
        Text high_score_text = high_score_object.GetComponent<Text>();
        high_score_text.text = "HighScore:" + high_score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
