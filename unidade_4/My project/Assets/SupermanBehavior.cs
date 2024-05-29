using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Vuforia;

public class SupermanBehavior : MonoBehaviour
{
    public GameObject m_shotPrefab;
    public ModelTargetBehaviour m_superman_target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 || Input.GetKeyDown(KeyCode.Space))
        {
            if (m_superman_target.TargetStatus.StatusInfo == StatusInfo.NORMAL)
            {
                m_shotPrefab.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                GameObject go = GameObject.Instantiate(m_shotPrefab, m_superman_target.transform.position, m_superman_target.transform.rotation) as GameObject;
                GameObject.Destroy(go, 3f);
            }
        }
    }
}
