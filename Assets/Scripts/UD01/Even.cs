using UnityEngine;

public class Even : MonoBehaviour
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

        for (int i = 0; i <= 100; i += 2)
        {
            Debug.Log(i);


        }

    }
}
