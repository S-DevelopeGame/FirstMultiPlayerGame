using Com.MyCompany.MyGame;
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionShield : MonoBehaviourPun
{
    //[SerializeField] private Transform shield;
    [SerializeField] private GameObject shield;
    [SerializeField] private int timeStayShield;
    private void OnTriggerEnter(Collider hit)
    {

        if (hit.gameObject.tag == "Shield" && !shield.activeSelf && PlayerManager.LocalPlayerInstance.GetPhotonView().IsMine)
        {
            Debug.Log("Enter Shield");

            Destroy(hit.gameObject);
            StartCoroutine(ShieldTemporarily());
            
        }
    }

    
    private IEnumerator ShieldTemporarily()
    {

        shield.SetActive(true);
        yield return new WaitForSeconds(timeStayShield);
        shield.SetActive(false);

    }

}
