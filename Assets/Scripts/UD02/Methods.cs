using UnityEngine;

public class Methods : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Soy el Awake y me ejecuto en primer lugar." + Time.deltaTime);
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Soy el Star y me ejecuto en segundo lugar." + Time.deltaTime);
    }



    private void FixedUpdate()
    {
        Debug.Log("Soy el FixedUpdate y me ejecuto constantemente en tercer lugar." + Time.deltaTime);
    }



    // Update is called once per frame
    void Update()
    {
        Debug.Log("Soy el Update y me ejecuto en cuarto lugar." + Time.deltaTime);
    }


    private void LateUpdate()
    {
        Debug.Log("Soy el LateUpdate y me ejecuto en quinto lugar.");
    }


}
