using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LancerJeuHumain()
    {
        // On pourra stocker une variable ici plus tard pour dire "C'est l'humain"
        SceneManager.LoadScene("Level1");
    }

    public void LancerJeuAgent()
    {
        // Pour l'instant, on fait la même chose ou on affiche un message
        Debug.Log("L'agent n'est pas encore prêt !");
        SceneManager.LoadScene("Level1");
    }
}