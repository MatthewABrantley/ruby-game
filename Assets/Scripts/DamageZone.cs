using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    // IF the 2d Collider "stays" collides with Ruby's collider/controller, deal Ruby damage
    private void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if(controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}
