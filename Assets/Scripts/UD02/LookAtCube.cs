using UnityEngine;

public class LookAtCube : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private Transform _myCube;
    
    
    // Update is called once per frame
    void Update()
    {
        LookCube();

    }


    private void LookCube()
    {
        //En este caso decimos nuestra posición, 
        //es decir, quien posee el script, en este caso en la cámara
        //la suya propia es "transform.LookAt"
        //entre paréntesis indicamos a quién estamos viendo

        transform.LookAt(_myCube);
    }

}
