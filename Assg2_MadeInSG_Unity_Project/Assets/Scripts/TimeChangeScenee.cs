using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeChangeScenee : MonoBehaviour
{
   
    private float Timer = 5f;
    private TextMeshProUGUI timerSeconds;

    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        timerSeconds.text = Timer.ToString();
        if (Timer <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
