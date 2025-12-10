using UnityEngine;

public class Score : MonoBehaviour
{
    //Zona de variables globales
    //puntos introducidos por el usuario
    [SerializeField]
    private int _points; 

    void Start()
    {
        CheckScore(_points);
    }

    private void CheckScore(int score)
    {
        if (score >= 45)
        {
            Debug.Log("¡Has alcanzado la puntuación!");
        }
        else
        {
            Debug.Log("Aún no has llegado a la puntuación.");
        }
    }
}
