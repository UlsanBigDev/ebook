using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public Slider volumeSlider;
    public System.Single currentVolume;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void VolumeHandle(System.Single vol)
    {
        currentVolume = vol;
    }

    public void SliderPop()
    {
        if(volumeSlider.gameObject.activeSelf == true)
        {
            volumeSlider.gameObject.SetActive(false);
        }
        else
        {
            volumeSlider.gameObject.SetActive(true);
        }
    }
    public void SelectBook(int bookId)
    {
        Debug.Log("당신이 선택한 책의 아이디 : " + bookId);
        SceneManager.LoadScene("Book"+bookId);
    }

    public void BookEscape()
    {
        SceneManager.LoadScene("MainScene");
    }
}
