using UnityEngine;

public class RabbitMovementAxis : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private float _speed = 0.8f;
    [SerializeField]
    private float _turnSpeed = 45.0f;

    [SerializeField]
    private float _vertical;
    [SerializeField]
    private float _horizontal;


    // Update is called once per frame
    void Update()
    {
        InputCube();

    }


    private void InputCube()
    {
        //con "Input" recogemos la introducción de datos
        //con "GetAxis" indicamos que estos datos queremos que se recojan
        //a través del eje "Horizontal", que es el nombre que tiene el eje
        //dentro de los Project Settings

        //Recogemos teclas A, D y las flechas del teclado < y >
        _horizontal = Input.GetAxis("Horizontal");

        //Recogemos teclas W, S y las flechas del teclado ^ y v
        _vertical = Input.GetAxis("Vertical");


        //Aplicamos el valor del eje vertical al "translate"
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);
        //Aplicamos el valor del eje vertical al "rotate"
        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);

    }

}
