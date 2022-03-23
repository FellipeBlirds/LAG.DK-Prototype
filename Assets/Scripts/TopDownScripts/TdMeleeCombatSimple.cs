using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TdMeleeCombatSimple : MonoBehaviour
{
    //https://www.youtube.com/watch?v=p6Klz_NZpEQ&list=PL4vbr3u7UKWp0iM1WIfRjCDTI03u43Zfu&index=13&ab_channel=MisterTaftCreates
    //existe um upgrade a ser feito nesse codigo, fazer o PlayerState, ele ensina no video
    //pra por exemplo voce só poder atacar quando não estiver atacando
    //e não poder se mexer quando estiver atacando

    public Animator animator;
    //no inspector voce precisa definir qual é animator que esse script vai controlar, e tbm dentro desse animator precisa ter o "attacking" pra quando o player atacar
    ///acho q existe uma forma de eu tornar isso mais facil, deve ter como definir no codigo para ele procurar o animator certo do player

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(AttackCoroutine());   
        }

    }

    private IEnumerator AttackCoroutine()
    {
        animator.SetBool("attacking", true);
        yield return null;
        animator.SetBool("attacking", false);
        yield return new WaitForSeconds(0.3f);
    }

    

}
