using UnityEngine;

public class Clon : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private GameObject _acorn;
    [SerializeField]
    private Transform _posRotSquirrel;
    [SerializeField]
    private float _empujeY;
    [SerializeField]
    private float _empujeZ;
    [SerializeField]
    private float _timeDestroy;


    // Update is called once per frame
    void Update()
    {
        CreateAcorns();
    }


    private void CreateAcorns()
    {
        //el 0 entre paréntesis se refiere al click izquierdo del ratón

        if (Input.GetMouseButtonDown(0))
        {
            //Instanciamos prefabs e indicamos desde que posición y rotación
            GameObject cloneAcorn = Instantiate(_acorn, _posRotSquirrel.position, _posRotSquirrel.rotation);

            //El componente "rigidbody" con el que voy a trabajar es el de los clones de la bellota
            Rigidbody rbAcorn = cloneAcorn.GetComponent<Rigidbody>();

            //Destruyo la bellota instanciada después de 2 segundos
            //Destroy(cloneAcorn, 2.0f);

            //Refactorizo para poder modificar el tiempo de destrucción a mi antojo
            Destroy(cloneAcorn, _timeDestroy);

            //La ardilla se destruye después de lanzar la bellota instanciada
            //Destroy(gameObject);

            //El script se destruirá después del click del ratón
            //Destroy(this);


            //Aplicamos una fuerza hacia arriba en el espacio global de la escena
            //al usar el espacio global utilizamos el "Vector3."
            rbAcorn.AddForce(Vector3.up * _empujeY);

            //Aplicamos una fuerza hacia delante en el eje Z local, de la propia ardilla
            //al usar el espacio local de la ardilla, usamos el "transform."
            rbAcorn.AddForce(transform.forward * _empujeZ);

        }


    }



}
