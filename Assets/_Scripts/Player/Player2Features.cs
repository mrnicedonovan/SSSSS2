using UnityEngine;
using System.Collections;

public class Player2Features : MonoBehaviour
{
    //Animator animator;
    private Renderer invis;
    private bool invisible = false;
    public float timeOfInvisi;
    // Use this for initialization
    void Start()
    {
        //animator = GetComponent<Animator>();
        invis = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetBool("attack", true);
        bool shoot = Input.GetKeyDown(KeyCode.N);
        shoot |= Input.GetKeyDown(KeyCode.M);

        if (timeOfInvisi >= 5)
        {
            invis.enabled = true;

            invisible = false;
        }
        if (shoot)
        {
            WeaponBehaviour weapon = GetComponent<WeaponBehaviour>();
            if (weapon != null)
            {
                // false because the player is not an enemy
                weapon.Attack(false);
            }
        }

            if (Input.GetKeyDown(KeyCode.L))
            {
                if (invisible == false)
                {
                    timeOfInvisi++;
                    invis.enabled = false;

                    invisible = true;
                }
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                if (invisible == true)
                {
                    invis.enabled = true;

                    invisible = false;
                }
            }

        }
   

}