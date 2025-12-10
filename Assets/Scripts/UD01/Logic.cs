using UnityEngine;

public class Logic : MonoBehaviour
{
    void Start()
    {
        GetBooleans();
    }

    private void GetBooleans()
    {
        bool[] booleansArray = new bool[3];

        booleansArray[0] = true;

        for (int i = 0; i < booleansArray.Length; i++)
        {
            Debug.Log(booleansArray[i]);
        }
    }

}
