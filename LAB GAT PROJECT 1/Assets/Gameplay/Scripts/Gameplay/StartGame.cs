﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public Player player;
    public GameObject character;
    public string selectSpawnLocationName;
    public Vector3 characterScale;
    public static string curScene;
    public static string newScene;

    public string Rumah;
    public string HutanAman;
    public string Kota;
    public string Hutan1_1;
    public string Hutan1_2;
    public string Hutan1_3;
    public string Hutan1_4;

    // Use this for initialization
    void Awake()
    {
        if (curScene == null)
        {
            curScene = Rumah;
        }
        
    }

    private void Start()
    {
        CheckScene();
        GameStatus.isTalking = false;
        GameStatus.ResumeGame();
        player = GameObject.Find("Player").GetComponent<Player>();
        player.LoadPlayer(selectSpawnLocationName);
    }

    void CheckScene()
    {
        newScene = SceneManager.GetActiveScene().name;
        if (curScene == Rumah)
        {
            if (newScene == HutanAman || newScene == Rumah)
            {
                selectSpawnLocationName = Rumah + "-" + HutanAman;
                curScene = newScene;
                Debug.Log(selectSpawnLocationName);
                return;
            }
        }
        else if (curScene == HutanAman)
        {
            if (newScene == Rumah)
            {
                selectSpawnLocationName = HutanAman + "-" + Rumah;
                curScene = newScene;
                //Debug.Log("oke2");
                return;
            }
            if (newScene == Kota)
            {
                selectSpawnLocationName = HutanAman + "-" + Kota;
                curScene = newScene;
               // Debug.Log("oke3");
                return;
            }
        }
        else if (curScene == Kota)
        {
            if (newScene == HutanAman)
            {
                selectSpawnLocationName = Kota + "-" + HutanAman;
                curScene = newScene;
                // Debug.Log("oke4");
                return;
            }
        }
    }
}
