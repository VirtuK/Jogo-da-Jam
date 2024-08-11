using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator npc_anim;

    // Update is called once per frame
    public void npc1()
    {
        npc_anim.Rebind();
        npc_anim.Update(0f);
        npc_anim.SetBool("Npc1", true);
    }

    public void npc2()
    {
        npc_anim.Rebind();
        npc_anim.Update(0f);
        npc_anim.SetBool("Npc2", true);
    }

    public void npc3()
    {
        npc_anim.Rebind();
        npc_anim.Update(0f);
        npc_anim.SetBool("Npc3", true);
    }

    public void npc4()
    {
        npc_anim.Rebind();
        npc_anim.Update(0f);
        npc_anim.SetBool("Npc4", true);
    }

    public void npc1StopToIdle()
    {
        npc_anim.SetBool("NPC1_Idle", true);
        npc_anim.SetBool("NPC1_Walk", false);
    }
    public void npc1StopToWalk()
    {
        npc_anim.SetBool("NPC1_Idle", false);
        npc_anim.SetBool("NPC1_Walk", true);

    }

    public void npc1IdleToWalk() 
    {
        npc_anim.SetBool("NPC1_Walk", true);
    }

    public void npc1WalkToStop() 
    {
        npc_anim.SetBool("NPC1_Walk", false);
    }

    public void npc1IdleToStop()
    {
        npc_anim.SetBool("NPC1_Idle", false);
        npc_anim.SetBool("NPC1_Walk", false);
    }


    public void npc2StopToIdle()
    {
        npc_anim.SetBool("NPC2_Idle", true);
        npc_anim.SetBool("NPC2_Walk", false);
    }
    public void npc2StopToWalk()
    {
        npc_anim.SetBool("NPC2_Idle", false);
        npc_anim.SetBool("NPC2_Walk", true);

    }

    public void npc2IdleToWalk()
    {
        npc_anim.SetBool("NPC2_Walk", true);
    }

    public void npc2WalkToStop()
    {
        npc_anim.SetBool("NPC2_Walk", false);
    }

    public void npc2IdleToStop()
    {
        npc_anim.SetBool("NPC2_Idle", false);
        npc_anim.SetBool("NPC2_Walk", false);
    }


    public void npc3StopToIdle()
    {
        npc_anim.SetBool("NPC3_Idle", true);
        npc_anim.SetBool("NPC3_Walk", false);
    }
    public void npc3StopToWalk()
    {
        npc_anim.SetBool("NPC3_Idle", false);
        npc_anim.SetBool("NPC3_Walk", true);

    }

    public void npc3IdleToWalk()
    {
        npc_anim.SetBool("NPC3_Walk", true);
    }

    public void npc3WalkToStop()
    {
        npc_anim.SetBool("NPC3_Walk", false);
    }

    public void npc3IdleToStop()
    {
        npc_anim.SetBool("NPC3_Idle", false);
        npc_anim.SetBool("NPC3_Walk", false);
    }


    public void npc4StopToIdle()
    {
        npc_anim.SetBool("NPC4_Idle", true);
        npc_anim.SetBool("NPC4_Walk", false);
    }
    public void npc4StopToWalk()
    {
        npc_anim.SetBool("NPC4_Idle", false);
        npc_anim.SetBool("NPC4_Walk", true);

    }

    public void npc4IdleToWalk()
    {
        npc_anim.SetBool("NPC4_Walk", true);
    }

    public void npc4WalkToStop()
    {
        npc_anim.SetBool("NPC4_Walk", false);
    }

    public void npc4IdleToStop()
    {
        npc_anim.SetBool("NPC4_Idle", false);
        npc_anim.SetBool("NPC4_Walk", false);
    }
}
