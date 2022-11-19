using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void SelectBook(int bookId) {
        Debug.Log("당신이 선택한 책의 아이디 : " + bookId);
        SceneManager.LoadScene("Book"+bookId);
    }
}
