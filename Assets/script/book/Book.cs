using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour, IBook
{
    public string subject;
    public GameObject[] storys;

    void Awake()
    {
        Transform storyList = this.transform.GetChild(0);
        this.storys = new GameObject[storyList.childCount];
        for (int i = 0; i < storyList.childCount; i++) {
            GameObject go = storyList.GetChild(i).gameObject;
            this.storys[i] = go;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
