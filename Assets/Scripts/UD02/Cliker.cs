using UnityEngine;

public class Cliker : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private float _fuerzaSalto;
    private Rigidbody _rb;


    private void Awake()
    {

        _rb = GetComponent<Rigidbody>();

    }


    private void OnMouseDown()
    {
       
        _rb.AddForce(transform.up * _fuerzaSalto, ForceMode.Force);

        //el "Force" calcula la fuerza por newtons
    }


}
