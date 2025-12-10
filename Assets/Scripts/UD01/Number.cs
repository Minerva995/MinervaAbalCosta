using UnityEngine;

public class Number : MonoBehaviour
{
    //Zona de variables globales
    //número que puede introducir el usuario
    [SerializeField]
    private int _number; 

    void Start()
    {
        IncreaseNumber(_number);
    }

    private void IncreaseNumber(int number)
    {
        int result = number + 1;
        Debug.Log("El número incrementado en 1 es: " + result);
    }


}
