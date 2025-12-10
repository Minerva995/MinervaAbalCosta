using UnityEngine;

public class AttackPinkGirl : MonoBehaviour
{
    //Zona de variables globales

    [Header("Elements")]
    [SerializeField]
    private GameObject _ball;
    [SerializeField]
    private Transform _posRot;

    [Header("Physics")]
    [SerializeField]
    private float thrustY;
    [SerializeField]
    private float thrustZ;
    [SerializeField]
    private float timeBall;



    // Update is called once per frame
    void Update()
    {
        InputCreateBalls();
    }


    private void InputCreateBalls()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateBalls();
        }

    }


    private void CreateBalls()
    {

        if (Input.GetMouseButtonDown(0))
        {

            GameObject cloneBall = Instantiate(_ball, _posRot.position, _posRot.rotation);

            //El componente "rigidbody" con el que voy a trabajar es el de los clones de la pelota
            Rigidbody rbBall = cloneBall.GetComponent<Rigidbody>();


            //"Vector3" para hacer referencia al eje Y global de la escena
            rbBall.AddForce(Vector3.up * thrustY);


            //"transform.forward" para hacer referencia al eje Z de "_posRot"
            rbBall.AddForce(transform.forward * thrustZ);

            //Destruir la bola
            Destroy(cloneBall, timeBall);

        }


    }
}
