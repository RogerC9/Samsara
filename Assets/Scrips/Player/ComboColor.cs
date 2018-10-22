using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboColor : MonoBehaviour {
	public Material materialA;
	public Material materialB;
	public Material materialC;
	public Material standard;
	public Renderer rend;
	public int animationAttack = 0;
	public float timeColdownAuto;
	void Start () 
	{
		rend=GetComponentInChildren<Renderer>();
        

    }


    void Update()
    {
        AnimatorAttack();
        }


    
        public void AnimatorAttack()
        {
    if (timeColdownAuto >= 1)
    {
        rend.material = standard;
        timeColdownAuto = 0;
        animationAttack = 0;
    }
    if ((animationAttack == 1) || (animationAttack == 2) || (animationAttack == 3))
    {
        timeColdownAuto += Time.deltaTime;

    }

    switch (animationAttack)
    {
        case 4:

            if (Input.GetButtonDown("Fire1") && (animationAttack == 3))
            {
                animationAttack = 0;
                rend.material = materialA;
            }
            break;

        case 3:

            if (Input.GetButtonDown("Fire1") && (animationAttack == 3))
            {
                animationAttack = 0;
                rend.material = materialA;
            }
            break;

        case 2:
            if (Input.GetButtonDown("Fire1") && (animationAttack == 2))
            {
                animationAttack++;
                rend.material = materialC;
                timeColdownAuto = 0;
            }
            break;
        case 1:
            if (Input.GetButtonDown("Fire1") && (animationAttack == 1))
            {
                animationAttack++;
                rend.material = materialB;
                timeColdownAuto = 0;
            }
            break;
        default:
            if (Input.GetButtonDown("Fire1") && (animationAttack == 0))
            {
                animationAttack++;
                rend.material = materialA;
                timeColdownAuto = 0;
            }
            break;
    }
    }
}
