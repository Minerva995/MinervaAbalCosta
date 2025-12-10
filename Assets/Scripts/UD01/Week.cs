using UnityEngine;

public class Week : MonoBehaviour
{
   

    //Zona de variables globales

    public int NumberWeek;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        IsNumberWeek();

    }


    private void IsNumberWeek()
    {

        switch (NumberWeek)
        {

            case 1:
                Debug.Log("Lunes");
                break;

            case 2:
                Debug.Log("Martes");
                break;

            case 3:
                Debug.Log("Miércoles");
                break;

            case 4:
                Debug.Log("Jueves");
                break;

            case 5:
                Debug.Log("Viernes");
                break;

            case 6:
                Debug.Log("Sábado");
                break;

            case 7:
                Debug.Log("Domingo");
                break;


        

            default:
                Debug.Log("El número introducido no se corresponde con ningún día de la semana.");
                break;


        }


    }

}
