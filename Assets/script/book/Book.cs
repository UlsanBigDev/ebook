using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour, IBook
{
    public string subject;
    public GameObject[] storys;
    public GameObject nowStory;
    public int page;

    void Awake()
    {
        this.page = 0;
        Transform storyList = this.transform.GetChild(0);
        this.storys = new GameObject[storyList.childCount];
        for (int i = 0; i < storyList.childCount; i++) {
            GameObject go = storyList.GetChild(i).gameObject;
            this.storys[i] = go;
        }
        // this.storys[0].SetActive(true);
        SetPage(this.page);
        
    }
    void ActiveStory(GameObject story) {
        Debug.Log(story);
        if (nowStory != null)
        {
            nowStory.SetActive(false);
        }
        nowStory = story;
        nowStory.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { // 좌클릭
            SetPage(this.page + 1);
        }

        if (Input.GetMouseButtonDown(1)) // 우클릭
        {
            SetPage(this.page - 1);
        }

    }

    public void SetPage(int page) {
        this.page = page;
        ActiveStory(this.storys[this.page]);
        OnPageChange(this.page);
    }

    public void OnPageChange(int page)
    {
        Debug.Log("페이지 체인지 이벤트");
    }
}
