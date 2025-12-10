using UnityEngine;

public class MovementPinkGirl : MonoBehaviour
{
    //Zona de variables
    
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _turnSpeed;

    
    private float _horizontal;
    private float _vertical;

    private Animator _anim;


    //Variable donde vamos a guardar la información del rayo
    private Ray _ray;
    //Guarda información del choque entre el "raycast" y el "collider" del "gameObject"
    private RaycastHit _hit;
    [SerializeField]
    private float _rayLenght;
    //Capa para que el rayo solo pueda detectar y colisionar con el suelo
    [SerializeField]
    private LayerMask _rayMask;


    private Rigidbody _rb;
    [SerializeField]
    private float _forceJump;
    private bool _isGrounded;
    private bool _canJump;



    private void Awake()
    {
       //mi variable "_anim" apunte al componente Animator
       //del "gameObject" que lleve este "script"
        _anim = GetComponent<Animator>();

        _rb= GetComponent<Rigidbody>(); 
    }


    //FixedUpdate es el método que se ocupa de las físicas
    private void FixedUpdate()
    {
        
        LaunchRaycast();

        if (_canJump == true)
        {
            _canJump = false;
            Jump();

        }

    }



    // Update is called once per frame
    void Update()
    {

        InputsPlayer();
        Move();
        Turn();

        Animating();
        CanJump();

    }



    private void Jump()
    {

        _rb.AddForce(Vector3.up * _forceJump);

    }




    private void LaunchRaycast()
    {

        _ray.origin = transform.position;

        //la transform solo tiene como direcciones up, forward y right
        //si quiero ir en la direccion "down"(hacia abajo), tendría que poner
        //el símbolo " - " delante de "transform.up" para que fuera negativo
        _ray.direction = -transform.up;
        
        
        if (Physics.Raycast(_ray, out _hit, _rayLenght, _rayMask))
        {

            Debug.Log("Estoy tocando el suelo");

            _isGrounded = true;

        }


        else
        {
            _isGrounded=false;

        }

        Debug.DrawRay(_ray.origin, _ray.direction, _rayLenght * 
            Color.red);
    }




    private void CanJump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded == true)
        {

            _canJump = true;

        }

    }





    private void InputsPlayer()
    {

        //Teclas A y D y las flechas < y > se van a usar

        _horizontal = Input.GetAxis("Horizontal");

        //Teclas W y S y las felchas arriba y abajo en cruzeta
        _vertical = Input.GetAxis("Vertical");

    }


    private void Move()
    {

        //Aplicamos el valor del eje vertical al "translate"
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);


    }


    private void Turn()
    {
        //Aplicamos el valor del eje horizontal al "rotate"
        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);

    }


    private void Animating()
    {
        if(_vertical != 0) //El personaje se está moviendo
        {
            _anim.SetBool("IsMoving", true);

        }


        else //"_vertical", su eje vertical, es igual a 0.0f, por lo que no se mueve
        {

            _anim.SetBool("IsMoving", false);

        }


    }


}
