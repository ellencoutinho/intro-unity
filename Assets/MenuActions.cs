using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour
{
    public void IniciaJogo()
    {
        GameController.Init();
        SceneManager.LoadScene(0);
    }

    public void Menu()
    {
        GameController.Init();
        SceneManager.LoadScene(1);
    }
}
