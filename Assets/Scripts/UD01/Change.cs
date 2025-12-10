using UnityEngine;

public class Change : MonoBehaviour
{
    void Start()
    {
        GetNumbers();
    }

    private void GetNumbers()
    {
        int[] numbersArray = new int[5];

        // poner todos a 1
        for (int i = 0; i < numbersArray.Length; i++)
        {
            numbersArray[i] = 1;
        }

        // cambiar el primero y el último
        numbersArray[0] = 42;
        numbersArray[4] = 42; // o numbersArray[numbersArray.Length - 1]

        // mostrar todos los valores
        for (int i = 0; i < numbersArray.Length; i++)
        {
            Debug.Log(numbersArray[i]);
        }
    }

}
