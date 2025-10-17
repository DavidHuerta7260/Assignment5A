/*
David Huerta
2D Prototype
Increments score when player collects a gem.
*/

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GemCollect : MonoBehaviour
{
    public int gemPoints = 1;
    public Animator anim;
    public AudioSource audioSource;
    public AudioClip sound;
    public float destroyDelay = 0.4f;

    private bool isCollected = false;

    void Start()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && isCollected == false)
        {
            isCollected = true;

            if (ScoreManager.instance != null)
            {
                ScoreManager.instance.AddScore(gemPoints);
            }

            GetComponent<Collider2D>().enabled = false;

            if (anim != null) anim.SetTrigger("Collect");
            if (audioSource != null && sound != null) audioSource.PlayOneShot(sound);

            Invoke("DestroyGem", destroyDelay);
        }
    }

    void DestroyGem()
    {
        Destroy(gameObject);

        if (ScoreManager.instance != null)
        {
            if (ScoreManager.instance.HasPlayerWon())
            {
                ScoreManager.instance.ShowWin();
            }
        }
    }
}