using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    private void Awake()
    {
        PlayerPrefs.SetInt("StopMusic", 0);
    }


}
