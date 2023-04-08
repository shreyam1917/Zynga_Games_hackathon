using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    int Spaceship_high_score = 0;
    public TMP_Text Spaceship_hs_text;
    // Start is called before the first frame update
    void Start()
    {
        Spaceship_hs_text.text = PlayerPrefs.GetInt("High_Score", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //Spaceship_high_score = Car_movmnt.score_value;
        if (Spaceship_high_score > PlayerPrefs.GetInt("High_Score", 0))
        {
            PlayerPrefs.SetInt("High_Score", Spaceship_high_score);
            Spaceship_hs_text.text = Spaceship_high_score.ToString();
        }
    }
}
