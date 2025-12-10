using UnityEngine;

public class Odd : MonoBehaviour
{
    //Zona de variables globales
    public int Number;


    // Start is called before the first frame update
    void Start()
    {
        GetNumber0To100For();

    }

    private void GetNumber0To100For()
    {


        //Crear el "for"

        for (int i = 1; i <= 100; i += 2)
        {
            Debug.Log(i);


        }

    }
}
