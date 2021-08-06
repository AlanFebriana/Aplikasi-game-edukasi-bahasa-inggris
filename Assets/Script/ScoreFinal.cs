using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreFinal : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text = "Result Score : " + PlayerPrefs.GetInt ("skor final").ToString();
    }
}
