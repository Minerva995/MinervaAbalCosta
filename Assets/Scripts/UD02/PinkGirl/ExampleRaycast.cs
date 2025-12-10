using UnityEngine;

public class ExampleRaycast : MonoBehaviour
{
    //Zona de variables globales

    //Variable donde vamos a guardar la información del rayo
    private Ray _ray;
    //Guarda información del choque entre el "raycast" y el "collider" del "gameObject"
    private RaycastHit _hit;
    [SerializeField]
    private float _rayLenght;
    [SerializeField]
    private LayerMask _enemyMask;

   

    // Update is called once per frame
    void Update()
    {
        _ray.origin = transform.position;

        //Hacia delante, hacia donde está mirando el personaje
        _ray.direction = transform.forward;

        //"out" le obliga al rayo a sacar la información y guardarla en el "_hit"

        if (Physics.Raycast(_ray, out _hit, _rayLenght, _enemyMask))
        {
            Debug.Log("Estoy chocando contra algo" + _hit.collider.name);

            Debug.Log("Punto del impacto:" + _hit.point);

            Debug.Log("Distancia a la que están el uno del otro:" + _hit.distance);


            _hit.collider.GetComponent<Rigidbody>().AddForce(Vector3.up * 300.0f);

        }

        Debug.DrawRay(_ray.origin, _ray.direction * _rayLenght, Color.red);

    }
}
