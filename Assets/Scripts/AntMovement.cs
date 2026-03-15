using UnityEngine;

public class AntMovement : MonoBehaviour
{

    //Zona de variables globales

    //Los puntos por donde quiero que patrulle la hormiga
    [SerializeField]
    private Transform[] _wayPointsArray;

    //Posiciones de la patrulla, es decir, cojo la "position" de la "transform" anterior
    [SerializeField]
    private Vector2[] _positionsArray;


    [SerializeField]
    private Vector3 _posToGo;


    //Variable index de tipo entero
    //Este index cuando se inicializa en una variable de tipo entero,
    //se iniciliza en 0
    private int _index;


    private SpriteRenderer _spriteRenderer;


    //Velocidad inicial de la hormiga
    [SerializeField]
    private float _speed;
    
    

    private void Awake()
    {
        _speed = 3.0f;

        _spriteRenderer = GetComponent<SpriteRenderer>();

        //Inicializamos el "array" de posiciones con el tamaño que tiene es de los "wayPoints"
        _positionsArray = new Vector2[_wayPointsArray.Length];

        //Inicializamos con un bucle indicando que haga un recorrido por el otro
        for(int i = 0; i < _wayPointsArray.Length; i++)
        {
            //Y cuando vaya haciendo un recorrido por cada uno de los elementos que hay en el WayPoint anterior,
            //lo que va a ocurrir es que se van a ir rellenando cada una de las posiciones
            //de mi neuvo Array (que es el _positionsArray)

            _positionsArray[i] = _wayPointsArray[i].position;
        }


        //La primera vez que la hormiga se pone en marcha, va a ir a esa posicion (_positionsArray),
        //es decir, cojemos el contenido de "_positionsArray" en el cajón cero y lo aisgno al "_posToGo"
        _posToGo = _positionsArray[0];

    }
    

    // Update is called once per frame
    void Update()
    {

        ChangeTargetPos();

        //El "MoveTowards" cambia el valor de un vector desde el valor en el que se encuentra
        //hasta el valor que queramos
        transform.position = Vector3.MoveTowards(transform.position, _posToGo, _speed * Time.deltaTime);


        Flip();
    }



    private void ChangeTargetPos()
    {

        //Preguntamos si hemos llegado a nuestro destino, que es uno de los Waypoints
        if(transform.position == _posToGo)
        {

            //Indico que si estoy en el último de mis Waypoints,
            //entonces me paso al indice 0
            //Vuelvo al punto inicial si he llegado al último cajón del "array"
            if(_index == _positionsArray.Length - 1)
            {

                _index = 0;
            }

            //Si no es así, quiero indicar al indice que continue hasta el siguiente
            //Si no he llegado al último cajón, contiúo el recorrido hasta el siguiente cajón
            else
            {

                _index++;
            }


            //Ahora estamos en el cajón 1, que es lo mismo que el Elemento 0
            _posToGo = _positionsArray[_index];

        }

    }





    private void Flip()
    {

        
        if (_posToGo.x > transform.position.x)
        {
            _spriteRenderer.flipX = true;

        }


        else if (_posToGo.x < transform.position.x)
        {

            _spriteRenderer.flipX = false;
        }

    }



}
