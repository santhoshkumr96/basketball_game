using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
        print(PlayerPrefs.GetInt("score"));
    }
}
