using UnityEngine;

public class VitaminiMovement : MonoBehaviour
{
    //Zona de variables globales
    [Header("Velocity")]
    [SerializeField]
    private float _speed;
    [SerializeField]
    //Tiempo que tardará Vitamini en alcanzar la velocidad que queremos
    private float _smoothTime;

    private Rigidbody2D _rb;
    private Animator _anim;
    private SpriteRenderer _spriteRenderer;

    //Vector 2 va a ser la velocidad a la que quiero mover el personaje
    private Vector2 _targetVelocity;
    private Vector2 _dampVelocity;


    [Header("Jump")]
    [SerializeField]
    private float _jumpForce;
    private bool _jumPressed;



    [Header("Raycast")]
    //Punto de origen del "raycast" ( a los pies de Squirrel)
    [SerializeField]
    private Transform _groundCheck;
    
    //Capa del suelo
    [SerializeField]
    private LayerMask _groundLayer;
    
    //Longitud del "raycast", necesario ponerlo porque si no se indica
    //el "raycast" tiende a Infinito
    [SerializeField]
    private float _rayLenght;

    //¿Estamos tocando el suelo? Comprobacion
    [SerializeField]
    private bool _isGrounded;



    private void Awake()
    {
        _jumPressed = false;

        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();

    }

   

    private void FixedUpdate()
    {
        Move();
        CanJump();
        ChangeGravity();
        //El Raycast se llama desde aquí porque trabaja con Physics
        RaycastGrounded();

        

    }

   
    private void CanJump()
    {
        if (_jumPressed == true)
        {
            Jump();
        }

    }



    private void RaycastGrounded()
    {

        _isGrounded = Physics2D.Raycast(_groundCheck.position, Vector2.down, _rayLenght, _groundLayer);

        //Para saber si funciona bien y para verlo dibujamos un rayo

        //Este rayo sale de nuestro objeto vacío, hacia abajo y multiplicado por una distancia
        //Y con un color visible

        Debug.DrawRay(_groundCheck.position, Vector2.down * _rayLenght, Color.red);

    }







    private void Jump()
    {

        //Reseteo la variable para que al saltar vuelva al suelo
        _jumPressed = false;

        _rb.AddForce(Vector2.up * _jumpForce);
    }




    private void ChangeGravity()
    {
        //Indico que si la velocidad de mi Rigidbody es menor a 0.0,
        //entonces cambio su gravedad a 3.5f
        if (_rb.linearVelocity.y < 0.0f)
        {

            _rb.gravityScale = 3.5f;
        }

        else
        {

            _rb.gravityScale = 1.0f;
        }

    }




    // Update is called once per frame
    void Update()
    {
        InputsPlayer();
    }




    private void InputsPlayer()
    {
        
        //Teclas que voy a usar (la A y D o < y > )
        //El avance en el eje X del personaje es igual a "Horizontal"
        float horizontal = Input.GetAxis("Horizontal");

        //recojo lo de la tecla de la derecha, es decir horizontal,
        //y lo mulyiplico por la velocidad que quiero (_speed)
        //_rb.linearVelocity.y , es para indiciar que la "Y" no es 0 
        // "Y" no es 0 porque el rb tiene una velocidad que se actualiza constantemente
        _targetVelocity = new Vector2(horizontal * _speed, _rb.linearVelocity.y);



        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded == true)
        {

            _jumPressed = true;
        }



        //Cuando indicamos "horizontal" entre los (),
        //estamos haciendo un paso por parámetro
        Flip(horizontal);

        Animating(horizontal);

    }



    private void Move()
    {
        //El “ref” lo que hace en este caso es registrar cada cambio en el Vector,
        //y luego lo guarda y se lo mete a la velocidad de “_rb” 

        _rb.linearVelocity = Vector2.SmoothDamp(_rb.linearVelocity, _targetVelocity, ref _dampVelocity, _smoothTime);

    }




    // h = horziontal, tengo que declararle una variable en este metodo
    private void Animating(float h)
    {

        //indicamos que cuando no se traslada la ardilla hacia la derecha tiene un valor 0
        // pero cuando comienza a correr la ardilla ese valor cambia
        // esto siguiente, " != ", quiere decir no es igual a
        // lo que venga despues del símbolo =
        

        if (h != 0.0f)
        {
            _anim.SetBool("IsRunning", true);

        }


        else
        {
            _anim.SetBool("IsRunning", false);

        }


        //Indicamos que la ardilla está saltando cuando el
        //valor de _isGrounded es distinto a verdadero
        // ! --> quiere decir que no es igual

        _anim.SetBool("IsJumping", !_isGrounded);

    }




    //Flip recibe una variable de tipo float,
    //la cual recibe los datos que le mande la llamada al método, osea "Flip(horizontal)"

    private void Flip(float h)
    {

        //Necesito acceder a la coordenada X del SpriteRenderer
        //Cuando Horizontal sea mayor que 0 quiero que se quede como está
        if (h > 0.0f)
        {
            _spriteRenderer.flipX = false;

        }


        //Cuando Horizontal vaya de 0 a -1 (es decir flecha izquierda)
        //el sprite debe voltearse

        else if(h < 0.0f)
        {

            _spriteRenderer.flipX = true;
        }

    }




    private void OnCollisionEnter2D(Collision2D infoCollision)
    {   
        //Tengo que entrar en el collider, desde una colisión inicial,
        //para llegar finalmente al Tag llamado Acorn del objeto
        if (infoCollision.collider.CompareTag("Acorn"))
        {   
            //Destruyo el objeto con el que colisione y que tenía ese Tag específico
            Destroy(infoCollision.collider.gameObject);

        }

    }


}
