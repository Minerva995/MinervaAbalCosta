using UnityEngine;

public class RabbitClon : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private GameObject _egg;
    [SerializeField]
    private Transform _posRotRabbit;
    [SerializeField]
    private float _empujeY;
    [SerializeField]
    private float _empujeZ;
    [SerializeField]
    private float _timeDestroy;


    // Update is called once per frame
    void Update()
    {
        CreateEggs();
    }


    private void CreateEggs()
    {
        //el 0 entre paréntesis se refiere al click izquierdo del ratón

        if (Input.GetMouseButtonDown(0))
        {
            //Instanciamos prefabs e indicamos desde que posición y rotación
            GameObject cloneEgg = Instantiate(_egg, _posRotRabbit.position, _posRotRabbit.rotation);

            //El componente "rigidbody" con el que voy a trabajar es el de los clones del huevo
            Rigidbody rbEgg = cloneEgg.GetComponent<Rigidbody>();

            

            //Refactorizo para poder modificar el tiempo de destrucción a mi antojo
            Destroy(cloneEgg, _timeDestroy);


            //Aplicamos una fuerza hacia arriba en el espacio global de la escena
            //al usar el espacio global utilizamos el "Vector3."
            rbEgg.AddForce(Vector3.up * _empujeY);

            //Aplicamos una fuerza hacia delante en el eje Z local, del propio conejo
            //al usar el espacio local del conejo, usamos el "transform."
            rbEgg.AddForce(transform.forward * _empujeZ);

        }


    }


}
