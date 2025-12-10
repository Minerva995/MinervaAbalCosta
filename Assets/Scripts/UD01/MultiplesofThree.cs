using UnityEngine;

public class MultiplesofThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }




    }
}
