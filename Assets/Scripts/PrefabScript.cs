using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrefabScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<Renderer>().isVisible)
        {
            // スコア保存
            int now_score = GameObject.FindGameObjectsWithTag("Item").Length;
            PlayerPrefs.SetInt("NOW_SCORE", now_score);
            PlayerPrefs.Save();

            // ハイスコアの保存
            int high_score = PlayerPrefs.GetInt("HIGH_SCORE", 0);
            if (high_score < now_score) {
                PlayerPrefs.SetInt("HIGH_SCORE", now_score);
                PlayerPrefs.Save();
            }

            // スコアシーンへ移動
            SceneManager.LoadScene("ScoreScene");
        }
    }
}
