using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator anim;
    public AudioSource attackSound;
    public bool isAttacking;
    public float attackTimer;
    // Start is called before the first frame update
    private void Start()
    {
        isAttacking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("Fire1") && !isAttacking)
        {
            StartCoroutine(Attacking());
        }
    }
    IEnumerator Attacking()
    {
        isAttacking = true;
        anim.Play("Attack");
        attackSound.Play();
        yield return new WaitForSeconds(attackTimer);
        isAttacking = false;

    }
}
