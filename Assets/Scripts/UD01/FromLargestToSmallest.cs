using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    //Zona de variables globales

    public int num1, num2, num3;

    void Start()
    {
        int[] numbers = { num1, num2, num3 };

        //Array de ordenacion de mayor a menor
        System.Array.Sort(numbers);
        Debug.Log("El orden de los números de mayor a menor es: " + numbers[2] + ", " + numbers[1] + ", " + numbers[0]);
    }

}
