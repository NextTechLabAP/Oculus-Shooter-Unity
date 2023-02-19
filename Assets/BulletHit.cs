using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
    public ParticleSystem hitVfx;
    public GameObject xrCamera;
    private void OnCollisionEnter(Collision other) {

        if(other.gameObject.tag == "Bullet") {
            Debug.Log("Bullet!!");
            Destroy(other.gameObject);
            ParticleSystem bulletVfx = Instantiate(hitVfx, other.gameObject.transform.position,  Quaternion.identity);
            bulletVfx.gameObject.transform.LookAt(xrCamera.transform);
            bulletVfx.Play();
            bulletVfx.time = 1f;
        }
    }
}
