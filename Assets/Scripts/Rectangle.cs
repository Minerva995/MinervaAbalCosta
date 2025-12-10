using UnityEngine;

public class Rectangle : MonoBehaviour
{
    //Variables globales
    private float _width;
    private float _height;

    // Start is called before the first frame update
    void Start()
    {

        _width = 12.5f;
        _height = 6.1f;


        GetArea();
        GetPerimeter();
        GetDiagonal();

    }

    private void GetArea()
    {
        //variables locales
        float area = 0.0f;

        //calcular el área
        area = _width * _height;

        //mostrar por Consola el resultado del área del rectángulo
        Debug.Log("El área del rectángulo es: " + area);

    }


    private void GetPerimeter()
    {
        //variables locales
        float perimeter = 0.0f;

        //calcular el perimetro
        perimeter = 2 * (_width * _height);

        //mostrar por Consola el perímetro del rectángulo
        Debug.Log("El perímetro del rectángulo es: " + perimeter);


    }

    private void GetDiagonal()
    {
        //variables locales
        float diagonal = 0.0f;

        //calcular la longitud de la diagonal
        diagonal = Mathf.Sqrt(Mathf.Pow(_width, 2) + Mathf.Pow(_height, 2));


        //mostrar por Consola la longitud de la diagonal
        Debug.Log("La longitud de la diagonal es: " + diagonal);
    }


}
