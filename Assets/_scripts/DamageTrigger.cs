using UnityEngine;
using System.Collections;

// Class that deals damage to any colliding entity with a HealthComponent attached
public class DamageTrigger : MonoBehaviour {

    [SerializeField]
    private int damageRate;
    private bool onlyHurtPlayer;

    public void OnTriggerStay2D(Collider2D hit)
    {
        HealthComponent collider = hit.gameObject.GetComponent<HealthComponent>();
        // Only do damage if colliding component has a HealthComponent
        if(collider)
        {
            collider.ChangeHealth((int)(-damageRate * Time.deltaTime));
        }
    }
}
