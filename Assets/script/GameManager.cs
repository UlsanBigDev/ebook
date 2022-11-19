using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

[System.Serializable]
public class UserData
{
    public float volume;

}

public class GameManager : MonoBehaviour
{   
    public Slider volumeSlider;
    //string path;
    public System.Single volume;
    float maxVolume = 100f;
    
    void Start()
    {
        //path = Path.Combine(Application.dataPath, "userdata.json");
        UserData userdata = new UserData();

    }

    public void OnValueChanged(System.Single vol){
        volume = vol;
    }

    public void VolumesliderPop(){
        if(volumeSlider.gameObject.activeSelf == true){
            volumeSlider.gameObject.SetActive(false);
        } else {
            volumeSlider.gameObject.SetActive(true);
        }

    }

    void Update()
    {
        //volumeSlider.value = volume / maxVolume;
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
