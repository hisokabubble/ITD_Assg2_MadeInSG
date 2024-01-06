using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{

    public float currentTime = 0f;
    public float startingTime = 5f;
    [SerializeField] TextMeshProUGUI coundownText;
    public GameObject toDisable;
    public GameObject toEnable;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        coundownText.text = currentTime.ToString("0");

        if(currentTime <= 3)
        {
            coundownText.color = Color.red;
        }
        if (currentTime <= 0)
        {
            currentTime = 0;
            toDisable.SetActive(false);
            toEnable.SetActive(true);
        }
    }
}
