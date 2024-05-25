using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.SocialPlatforms.Impl;

public class GhostKill : MonoBehaviour
{
    public GameObject ghost;
    public GameObject prey;
    public GameObject pacman;

    private Vector3 respawnPosition = new Vector3(-2,0.75f,-6);
    private Quaternion rp = new Quaternion(0, 90, 0, 0);

    public static int lives = 3;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider col)
    {

        if(col.gameObject.tag == "Player" && gameObject.tag == "Enemy")        //changing col.gameObject.tag to .name might have fixed the itch.io problem where pacman gets split in half after getting killed
        {
            lives--;
            print("OnTriggerEnter");
            respawnPacman();

            if (lives <= 0)
            {
                restartGame();
                EatMe.score = 0;
                lives = 3;
            }
        }
        deadGhostWalking(col);
    }

    public void deadGhostWalking(Collider col)
    {
        if (col.gameObject.tag == "Player" && gameObject.tag == "Prey")
        {
            StartCoroutine(resurrectGhostTimer());
            gameObject.SetActive(false);
        }
    }

    private IEnumerator resurrectGhostTimer()
    {
        yield return new WaitForSecondsRealtime(5f);
        gameObject.SetActive(true);
    }


    private void respawnPacman()
    {
        print("respawn()");
        pacman.gameObject.SetActive(false);
        StartCoroutine(respawnTimer());
    }

    private IEnumerator respawnTimer()
    {
        yield return new WaitForSecondsRealtime(1f);
        pacman.transform.SetPositionAndRotation(respawnPosition, rp);
        pacman.gameObject.SetActive(true);
    }

    
    public void restartGame()
    {
        if (lives <= 0)
        {
            lives = 3;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            FindObjectOfType<Button>().gameObject.SetActive(false);
        }
        else if (gameObject.activeInHierarchy.Equals(true)) 
        {
            FindObjectOfType<Button>().gameObject.SetActive(false);
        }
    }
    
}
