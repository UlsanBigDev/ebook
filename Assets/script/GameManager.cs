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
        Debug.Log("����� ������ å�� ���̵� : " + bookId);
        SceneManager.LoadScene("Book"+bookId);
    }
}
