using UnityEngine;

public class Activated : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private GameObject _myCamera;


    //private void Start()
   // {
        //gameObject.SetActive(false);

   // }


    // Update is called once per frame
    void Update()
    {
        ActivateCamera();  
    }


    private void ActivateCamera()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //para desactivarlo indico dentro del paréntesis "false"
            //para activarlo indico "true"
            _myCamera.SetActive(false);


        }


        if (Input.GetKeyDown(KeyCode.E))
        {
            _myCamera.SetActive(true);

        }

    }

}
