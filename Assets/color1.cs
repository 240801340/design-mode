using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class color1 : MonoBehaviour, IPointerClickHandler
{
    private MeshRenderer msRender;
    private Transform t;
    // Start is called before the first frame update
    void Start()
    {
        t = this.transform;
        //msRender = GetComponent<MeshRenderer>();

        // 设置物体的初始颜色
        //msRender.material.color = Color.red;
        /*foreach (Transform child in this.transform)
        {
            Debug.Log("children: " + child.name);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void aa(Transform t)
    {
        foreach (Transform child in t)
        {
            if (child.GetComponentsInChildren<Transform>(true).Length <= 1)
            {
                bb(child);
                Debug.Log("children: " + child.name);
            }
            else
            {
                aa(child);
            }
        }
    }

    public void bb(Transform t)
    {
        t.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        aa(t);
    }
}
