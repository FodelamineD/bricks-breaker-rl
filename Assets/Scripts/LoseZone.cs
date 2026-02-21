using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si c'est la balle qui touche le bas
        if (collision.CompareTag("Ball") || collision.name == "Ball")
        {
            Debug.Log("PERDU ! On recommence."); // Vérifie si ce message s'affiche en console
            
            // Recharge la scène active
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}