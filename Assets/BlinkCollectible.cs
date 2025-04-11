using UnityEngine;

public class BlinkCollectible : MonoBehaviour
{
    public float blinkInterval = 0.5f; // tempo entre piscadas

    private Renderer rend;
    private float timer;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= blinkInterval)
        {
            rend.enabled = !rend.enabled; // alterna visibilidade
            timer = 0f;
        }
    }
}
