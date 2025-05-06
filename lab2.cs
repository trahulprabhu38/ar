using UnityEngine;

public class SecondLab : MonoBehaviour
{
    public Animator anim;

    public void one()
    {
        anim.SetBool("a", false);
        anim.SetBool("b", false);   
        anim.SetBool("c", false);  
    }

    public void two()
    {
        anim.SetBool("a", true);
        anim.SetBool("b", false);
        anim.SetBool("c", false);
    }

    public void three()
    {
        anim.SetBool("a", false);
        anim.SetBool("b", true);
        anim.SetBool("c", false);
    }

    public void four()
    {
        anim.SetBool("a", false);
        anim.SetBool("b", false);
        anim.SetBool("c", true);
    }
}
