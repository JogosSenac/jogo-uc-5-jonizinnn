using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tempo : MonoBehaviour
{
    public TMP_Text timeText;

    private float timeElapsed;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        timeText.text = "Tempo: " + timeElapsed.ToString("F2") + "s";
    }

}
