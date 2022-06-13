using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Rigidbody rb; //Получения и инициализация компонентов
    //private Animator animator;

    //void Start()
    //{
    //    rb = gameObject.transform.parent.GetComponent<Rigidbody>();
    //    animator = GetComponent<Animator>();
    //}

    //void Update()
    //{
    //    if (rb.velocity.magnitude != 0) //Если персонаж двигается => проигрываем анимацию бега
    //    {
    //        animator.SetBool("isRun", true);
    //    }
    //    else
    //    {
    //        animator.SetBool("isRun", false);
    //    }
    //}

    //public void PlayerPass() //Даем пасс
    //{
    //    animator.SetTrigger("pass");
    //}
}
