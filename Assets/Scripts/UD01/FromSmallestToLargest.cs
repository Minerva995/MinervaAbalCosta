using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    //Variables globales

    public int num1, num2, num3;

    void Start()
    {
        int[] numbers = { num1, num2, num3 };

        //Array de ordenacion de menor a mayor
        System.Array.Sort(numbers);
        Debug.Log("El orden de los números de menor a mayor es: " + numbers[0] + ", " + numbers[1] + ", " + numbers[2]);
    }
}
