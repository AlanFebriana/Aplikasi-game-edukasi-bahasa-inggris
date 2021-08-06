using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject main;
    public GameObject skor;
    public GameObject about;
    public GameObject exit;


    private AudioSource soundButton;

    private void Start()
    {
        soundButton = GetComponent<AudioSource>();
    }

    public void ToMain()
    {
        main.SetActive(true);
        skor.SetActive(false);
        about.SetActive(false);
        exit.SetActive(false);
        soundButton.Play();
    }

    public void Toskor()
    {
        main.SetActive(false);
        skor.SetActive(true);
        soundButton.Play();

    }
    public void ToAbout()
    {
        main.SetActive(false);
        about.SetActive(true);
        soundButton.Play();

    }
    public void ToExit()
    {
        main.SetActive(false);
        exit.SetActive(true);
        soundButton.Play();

    }

}
