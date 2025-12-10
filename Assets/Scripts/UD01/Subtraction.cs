
using UnityEngine;

public class Subtraction : MonoBehaviour
{
    //Zona de varibales globales
    //el número que puede introducir el usuario
    public int Number;
  
    

    // Start is called before the first frame update
    void Start()
    {

        int resultado = 1;
        for (int i = 2; i <= Number; i++)
        {
            resultado = resultado - i;
        }
        Debug.Log("La resta de los números desde el 1 al " + Number + " es: " + resultado);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
