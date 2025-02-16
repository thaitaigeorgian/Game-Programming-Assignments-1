using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget1 : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 TargetPos = target.transform.position;

        transform.position = new Vector3(TargetPos.x, 0, -10);

    }
}
