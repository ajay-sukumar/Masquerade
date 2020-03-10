﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Task3 : MonoBehaviour {

    public GameObject Panel1, Panel2, Panel3, Panel4, Panel5, Panel6, CluePanel, Cam;
    void Start()
    {
        /*Panel1 = GameObject.Find("Panel1");
        Panel2 = GameObject.Find("Panel2");
        Panel3 = GameObject.Find("Panel3");
        Panel4 = GameObject.Find("Panel4");
        Panel5 = GameObject.Find("Panel5");
        Panel6 = GameObject.Find("Panel6");
        videoPlayer = GameObject.Find("Video Player");
        CluePanel = GameObject.Find("CluePanel");
        Cam = GameObject.Find("ARCamera");*/
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        CluePanel.SetActive(false);
        Cam.SetActive(false);
    }
	public void next1()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(true);
    }

    public void previous2()
    {
        Panel2.SetActive(false);
        Panel1.SetActive(true);
    }

    public void next2()
    {
        Panel2.SetActive(false);
        Panel3.SetActive(true);
    }

    public void previous3()
    {
        Panel3.SetActive(false);
        Panel2.SetActive(true);
    }

    public void next3()
    {
        Panel3.SetActive(false);
        Panel4.SetActive(true);
    }

    public void previous4()
    {
        Panel4.SetActive(false);
        Panel3.SetActive(true);
    }

    public void next4()
    {
        Panel4.SetActive(false);
        Panel5.SetActive(true);
    }

    public void previous5()
    {
        Panel5.SetActive(false);
        Panel4.SetActive(true);
    }

    public void next5()
    {
        Panel5.SetActive(false);
        Panel6.SetActive(true);
    }

    public void previous6()
    {
        Panel6.SetActive(false);
        Panel5.SetActive(true);
    }

    public void clue()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        CluePanel.SetActive(true);

    }

    public void story()
    {
        CluePanel.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel1.SetActive(true);
    }

    public void camera()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        CluePanel.SetActive(false);
        vars.task++;
        SceneManager.LoadScene("Task4");
    }
}
