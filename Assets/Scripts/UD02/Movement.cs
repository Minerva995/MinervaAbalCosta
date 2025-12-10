using UnityEngine;

public class Movement : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _turnSpeed;

    [SerializeField]
    private Space _mySpace;
    [SerializeField]
    private KeyCode _myKey;
    [SerializeField]
    private ForceMode _myForceMode;


    // Update is called once per frame
    void Update()
    {

        //Sitúo el movimiento en el Update porque quiero que esté disponible
        //su movimiento de manera constante (repasar teoria awake, start,fixedupdate,update y lateupdate)

        // transform.Translate(Vector3.forward * _speed * Time.deltaTime, _mySpace);
        // transform.Rotate(Vector3.up * Time.deltaTime * _turnSpeed);


        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate(Vector3.forward * _speed * Time.deltaTime);


        }


       if (Input.GetKey(KeyCode.S))
        {

            transform.Translate(Vector3.back * _speed * Time.deltaTime);


        }


        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(Vector3.up * _turnSpeed * Time.deltaTime);


        }



        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(Vector3.down * _turnSpeed * Time.deltaTime);
            
            //transform.Rotate(-Vector3.up * _turnSpeed * Time.deltaTime);

        }


    }
}
