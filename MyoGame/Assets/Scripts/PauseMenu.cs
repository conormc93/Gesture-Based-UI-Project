using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

public class PauseMenu : MonoBehaviour
{
    //Constants and Variables
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public GameObject myo = null;

    // Update is called once per frame
    void Update()
    {
        ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo>();

        //Pausing game with Esc key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if(thalmicMyo.pose == Pose.DoubleTap)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

            ExtendUnlockAndNotifyUserAction(thalmicMyo);
        }
        else if(thalmicMyo.pose == Pose.FingersSpread)
        {
            SceneManager.LoadScene("1");

            ExtendUnlockAndNotifyUserAction(thalmicMyo);
        }
    }

    //Method which unpauses the game
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    //Method which pauses the game
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    //Method which quits the level
    public void QuitGame()
    {
        SceneManager.LoadScene("1");
    }

    void ExtendUnlockAndNotifyUserAction(ThalmicMyo myo)
    {
        ThalmicHub hub = ThalmicHub.instance;

        if (hub.lockingPolicy == LockingPolicy.Standard)
        {
            myo.Unlock(UnlockType.Timed);
        }

        myo.NotifyUserAction();
    }
}