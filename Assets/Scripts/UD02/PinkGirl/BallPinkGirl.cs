using UnityEngine;

public class BallPinkGirl : MonoBehaviour
{

    [SerializeField]
    private Material _mat;



    /* private void OnCollisionEnter(Collision infoCollision)
     {
         Debug.Log("He colisionado con algo" + infoCollision.gameObject.name);

         //Voy a ver si estoy chocando contra el cubo que es quien me interesa
         //Accedo para ello al "collider" del objeto con el que está chocando la pelota
         //y miro si la etiqueta es igual a la de "Enemy"


         if (infoCollision.collider.CompareTag("Enemy"))
         {

             //Cambio el material del cubo
             //Accedo a su componente "Renderer" y a su propiedad "material"
             infoCollision.gameObject.GetComponent<Renderer>().material = _mat;


         }




     }*/


    private void OnTriggerEnter(Collider infoAccess)
    {


        Debug.Log("Estoy colisionando con:" + infoAccess.gameObject.name);

        if (infoAccess.CompareTag("Enemy"))
        {   

            //este "InfoAccess" está haciendo referencia al cubo porque es el que tiene el tag Enemy
            Destroy(infoAccess.gameObject);

        }

    }


}
