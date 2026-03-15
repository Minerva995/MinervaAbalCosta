using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField]
    private Transform _player;

    //Distancia inicial entre la cámara y el "player"
    private Vector3 _offset;

    //Parámetro que necesita Unity para saber la velocidad actual a la que va el Vector
    //Registra y guarda el cambio de velocidad que tiene el Vector
    private Vector3 _smoothDampVelocity;

    //Necesito un "smoothDamp" como el de la ardilla en "VitaminiMovement"
    //Esto indica el tiempo que tarda la cámara en llegar a donde está el personaje
    [SerializeField]
    private float _smoothTargetTime;



    private void Awake()
    {
        //Estamos restando a nuestra posición la posición del player
        //Y el resultado de esta resta se la colocamos al "_offset",
        //que es la distancia que la cámara siempre va a mantener
        _offset = transform.position - _player.position;

    }


   

    // Update is called once per frame
    void Update()
    {

        MoveCamera();
        
    }



    private void MoveCamera()
    {
        //La posición de la cámara va a ser la que le arroje el Vector3
        //

        transform.position = Vector3.SmoothDamp(transform.position, 
            _player.position + _offset, ref _smoothDampVelocity, _smoothTargetTime);

    }




}
