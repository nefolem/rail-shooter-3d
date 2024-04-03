using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject laserShot;
    [SerializeField] GameObject leftGun;
    [SerializeField] GameObject rightGun;
    [SerializeField] float speed = 20000;
    private float time = 0f;
    [SerializeField] private float shotDelay = 0.8f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Fire();

        }
    }

    private void Fire()
    {
        time += Time.deltaTime;
        if (time >= shotDelay)
        {
            GameObject leftShit = Instantiate(laserShot, leftGun.transform.position, transform.rotation);
            GameObject rightShot = Instantiate(laserShot, rightGun.transform.position, rightGun.transform.rotation);

            leftShit.GetComponent<Rigidbody>().AddForce(transform.forward * speed * Time.deltaTime);
            rightShot.GetComponent<Rigidbody>().AddForce(transform.forward * speed * Time.deltaTime);

            time = 0;
        }
    }
}
