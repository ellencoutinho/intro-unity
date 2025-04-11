using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;
    private bool has_played = false;
    AudioSource end_audio;

    private float currentTime = 0f;
    public TextMeshProUGUI timerText_TMP;
    public TextMeshProUGUI TempoFinal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        end_audio = GetComponent<AudioSource>();
        UpdateTimerDisplay();
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
            TempoFinal.text = timerText_TMP.text;
            // Torna timerText_TMP invisivel
            timerText_TMP.color = new Color(timerText_TMP.color.r, timerText_TMP.color.g, timerText_TMP.color.b, 0f);

            endGamePanel.SetActive(true);
        }

        if (!GameController.gameOver)
        {        
            currentTime += Time.deltaTime;
            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {    
        timerText_TMP.text = Mathf.CeilToInt(currentTime).ToString();
    }
}
