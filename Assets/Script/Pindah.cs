using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Pindah : MonoBehaviour {


    public AudioSource audioSource;

    public void ToScene(string namaScene){

    
        StartCoroutine(ChangeScene(namaScene));

    }

    private IEnumerator ChangeScene(string nameScene)
    {

        float duration = audioSource.clip.length;
        audioSource.Play();
       
        AsyncOperation sceneLoading = SceneManager.LoadSceneAsync(nameScene);
        sceneLoading.allowSceneActivation = false;

        yield return new WaitForSeconds(duration);
        while (sceneLoading.progress < 0.9f) yield return null;
        sceneLoading.allowSceneActivation = true;

    }
    public void Quit(){

        Application.Quit ();

    }
    
}
