using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBackground : MonoBehaviour
{

    private static MusicBackground instance = null;
    public static MusicBackground Instance
    {
        get { return instance; }
    }

    void Awake()
    {
    
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("StopMusic", 0) == 1)
        {
            Destroy(this.gameObject);
            return;
        }

    }


}
