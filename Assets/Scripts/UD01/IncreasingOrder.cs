using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    //Variables globales

    public int num1, num2, num3;

    void Start()
    {
        if (num1 < num2 && num2 < num3)
        {
            Debug.Log("Los números se han introducido en orden creciente.");
        }
        else
        {
            Debug.Log("Los números no se han introducido en orden creciente.");
        }
    }

}
