using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    void Start()
    {
        GetRandomMessage();
    }

    private void GetRandomMessage()
    {
        string[] messagesArray = new string[5];
        messagesArray[0] = "Hoy será un buen día.";
        messagesArray[1] = "Voy a aprender algo nuevo.";
        messagesArray[2] = "Mi código funcionará a la primera.";
        messagesArray[3] = "Estoy mejorando en programación.";
        messagesArray[4] = "Unity es interesante.";

        int randomIndex = Random.Range(0, messagesArray.Length);

        Debug.Log("Mensaje aleatorio: " + messagesArray[randomIndex]);
    }
}
