using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private Transform _target;


    [Header("Vectors")]
    //Velocidad de seguimiento de la cámara
    [SerializeField]
    private float _smoothing;
    //Distancia inicial que hay entre la cámara y el "player"
    [SerializeField]
    private Vector3 _offset;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //Obtengo la distancia inicial entre cámara y "player"
        //Obtengo la posición de la cámara principal y le resto la posición inicial del "player"
        // el "_target" es el "player"

        _offset = transform.position - _target.position;

    }

    //Utilizo el LateUpdate porque ocurre siempre después del Update
    //lo que tenemos es un movimiento de cámara que se actualiza siempre después
    //del movimiento del personaje


    private void LateUpdate()
    {
        //Posición a la que queremos mover la cámara
        //obtengo la posición deseada sumando la posición del "player" con la posición
        //"_offset", que es a la que está siempre desde el inicio del juego

        Vector3 desiredPosition = _target.position + _offset;

        //Mover la cámara
        //con "Lerp" le decimos que haga una interpolación entre frame y keyframe
        //El "Lerp" suaviza las avanzadillas y parones de la cámara para que no sean tan cortantes
        
        transform.position = Vector3.Lerp(transform.position, desiredPosition, _smoothing * Time.deltaTime);


    }

}
