using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public Animator animator;
    public string danceAnimationName;
    public GameObject page1, page2, panel;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(true);
        page1.SetActive(true);
        page2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dance()
    {
        animator.SetTrigger(danceAnimationName);
    }

    public void NextButton()
    {
        page2.SetActive(true);
        page1.SetActive(false);
    }

    public void CloseButton()
    {
        panel.SetActive(false);
    }

    public void BackButton()
    {
        page1.SetActive(true);
        page2.SetActive(false);
    }
}
