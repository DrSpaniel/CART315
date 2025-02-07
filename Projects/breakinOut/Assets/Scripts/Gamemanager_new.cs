using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Gamemanager_new : MonoBehaviour
{
    public int points = 0;
    public int lives = 3;

    public static Gamemanager_new S; //instance of manager singleton

    void Awake(){
        //mainly used for singletons, awake runs immedeatley even before start

        S = this;
    }


    public void LoseLife(){
        lives -= 1;
        Debug.Log(lives);

        if (lives <= 0) GameOver();
    }

    public void GameOver(){
        SceneManager.LoadScene("GameOver");
    }

    public void AddPoint (){
        points += 1;
    }