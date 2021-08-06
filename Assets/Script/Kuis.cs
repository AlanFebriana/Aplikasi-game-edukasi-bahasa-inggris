using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Kuis : MonoBehaviour {
   
    [Header("Nyawa")]
    public Text textNyawa;
    public int nyawa;

    [Header("Feedback")]
    public GameObject benarUI;
    public GameObject salahUI;
    public GameObject pertanyaanUI;

    [Header("Pertanyaan")]
    [SerializeField] Text teksPertanyaan;
    [SerializeField] Text[] teksPilihan;
    [SerializeField] Soal[] soal;
    [SerializeField] int indeksSoal;

    [Header("EndKuis")]
    public GameObject gameFinist;
    public GameObject gameOver;
    public GameObject gameUI;

    void Start(){

        TampilkanSoal (UnityEngine.Random.Range(0,soal.Length));
        textNyawa.text = nyawa.ToString()+"x";

    }
  
    void TampilkanSoal(int _indeksSoal){

        indeksSoal = _indeksSoal;

        teksPertanyaan.text = soal [_indeksSoal].pertanyaan;

        for (int i = 0; i < soal[_indeksSoal].pilihan.Length; i++) {

            teksPilihan[i].text = soal[_indeksSoal].pilihan [i];

        }
    }

    public void VerifikasiJawaban(int _indeksJawaban){

        if(_indeksJawaban == soal[indeksSoal].indeksJawaban){
            print ("Benar!");
            int skor = PlayerPrefs.GetInt ("skor") + 10;
            PlayerPrefs.SetInt ("skor", skor);
            pertanyaanUI.SetActive(false);
            benarUI.SetActive(true);
        } else {
            print ("Salah!");
            nyawa -= 1;
            textNyawa.text = nyawa.ToString() + "x";
            pertanyaanUI.SetActive(false);
            salahUI.SetActive(true);
        }

        RemoveSoal(ref soal, indeksSoal);
       
    }
    public void PertanyaanSelanjutnya()
    {
        if (soal.Length == 0)
        {
            int skor = PlayerPrefs.GetInt("skor");
            PlayerPrefs.SetInt("skor final", skor);
            gameFinist.SetActive(true);
            gameUI.SetActive(false);

        }
        else if (nyawa <= 0)
        {
            int skor = PlayerPrefs.GetInt("skor");
            PlayerPrefs.SetInt("skor final", skor);
            gameUI.SetActive(false);
            gameOver.SetActive(true);

        }
        else
        {
            benarUI.SetActive(false);
            salahUI.SetActive(false);
            pertanyaanUI.SetActive(true);
            TampilkanSoal(UnityEngine.Random.Range(0, soal.Length));
        }
    }

    private void RemoveSoal<S>(ref S[] arr, int index)
    {
        for (int i = index; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }

        Array.Resize(ref arr, arr.Length - 1);
    }
}