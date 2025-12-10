using UnityEngine;

public class TestVector : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //como "myOrigin" es una variable local, la escribo en camelCase
        //establezco el punto original
        Vector2 myOrigin = new Vector2(0.0f, 0.0f);
        Vector2 myPoint = new Vector2(3.0f, 2.0f);

        //El método "DrawLine" dibuja en la escena, pero no en el game,
        //el vector que va desde "myOrigin" hasta "myPoint" de color rojo
        Debug.DrawLine(myOrigin, myPoint, Color.red);  

    }
}
