using UnityEngine;

public class AttackPinkGirlAnimator : MonoBehaviour
{
    //Zona de variables

    private Animator _anim;
    [SerializeField]
    private Collider _colliderAttack;


    private void Awake()
    {
        //mi variable "_anim" apunte al componente Animator
        //del "gameObject" que lleve este "script"
        _anim = GetComponent<Animator>();
    }
 

    // Update is called once per frame
    void Update()
    {
        InputAttack();

    }


    private void InputAttack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }


    private void Attack()
    {
        _anim.SetTrigger("Attack");

    }


    private void OnEnabledCollider()
    {
        //Activo el componente "collider" del Capsule Collider de la espada de PinkGirl
        _colliderAttack.enabled = true;
    }



    private void OnDisbleCollider()
    {
        //Deshabilito el componente para que el "collider" actúa en la escena
        //Deshabilito el componente "collider" del Capsule Collider de la espada de PinkGirl
        _colliderAttack.enabled = false;
    }


}
