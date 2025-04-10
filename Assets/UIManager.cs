using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;
    private bool has_played = false;
    AudioSource end_audio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        end_audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameController.gameOver)
        {
            if (!has_played)
            {
                end_audio.Play();
                has_played = true;
            }
            endGamePanel.SetActive(true);
        }
    }
}
