using UnityEngine;

public class StructsValues : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private Color _myColor = new Color(1.0f, 0.64f, 0.85f, 0.5f);
    [SerializeField]
    private Color32 _myTrueColor = new Color32(255, 165, 0, 128);
    [SerializeField]
    private Vector2 _myVectorTwo = new Vector2(1.5f, 2.5f);
    [SerializeField]
    private Vector3 _myVectorThree = new Vector3(1.5f, 2.5f, 3.5f);
    [SerializeField]
    private Quaternion _myQuaternion = Quaternion.identity;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
