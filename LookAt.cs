using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform LookTarget;
    public float Speed = 5f;

    // Object looks for a specific target
    void Update()
    {

        /*Vector3 relativePos = LookTarget.position - transform.position;
        Quaternion LookAtRotation = Quaternion.LookRotation(relativePos);

        Quaternion LookAtRotationOnly_X = Quaternion.Euler(LookAtRotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);

        transform.rotation = LookAtRotationOnly_X;
        */

        Vector3 originalRotation = this.transform.rotation.eulerAngles;

        Vector3 targetDir = LookTarget.transform.position - transform.position;
        float step = Speed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
        Debug.DrawRay(transform.position, newDir.normalized * 1000f, Color.red, 0.1f);
        transform.rotation = Quaternion.LookRotation(newDir);

        transform.rotation = Quaternion.Euler(originalRotation.x, this.transform.rotation.eulerAngles.y, originalRotation.z);
    }
}
