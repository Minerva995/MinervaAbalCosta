using UnityEngine;

public class ComponentGet : MonoBehaviour
{
    //Zona de variables globales
    private Light _myLight;
    [SerializeField]
    private BoxCollider _myCubeCollider;


    private void Awake()
    {
        //Obtengo mi componente "Light" de la Directional Light
        //Inicialización del componente Light
        //porque mi "gameObject" tiene ese componente

        _myLight = GetComponent<Light>();

       
    }
   
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Deshabilitamos el componente "Light"
        //con "false" lo deshabilito, y con "true" lo habilito
        _myLight.enabled = false;

        _myCubeCollider.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
