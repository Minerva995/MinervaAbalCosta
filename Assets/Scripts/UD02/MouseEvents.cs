using UnityEngine;

public class MouseEvents : MonoBehaviour
{

    private void OnMouseDown()
    {
        Debug.Log("Actúo cuando hago clic con el botón izquierdo del ratón " +
            "encima del collider");
    }

    private void OnMouseOver()
    {
        Debug.Log("Actúo cuando el ratón está sobre el collider");
    }

    private void OnMouseEnter()
    {
        Debug.Log("Actúo cuando hago entro en el collider");
    }

    private void OnMouseExit()
    {
        Debug.Log("Actúo cuando salgo del collider");
    }

    private void OnMouseDrag()
    {
        Debug.Log("Actúo cuando arrastro el ratón por el collider");
    }

}
