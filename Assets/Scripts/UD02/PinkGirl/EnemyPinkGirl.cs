using UnityEngine;

public class EnemyPinkGirl : MonoBehaviour
{



    private void OnTriggerEnter(Collider infoAccess)
    {
        if (infoAccess.CompareTag("AttackPlayer"))
        {
            Destroy(gameObject);

        }

    }




}
