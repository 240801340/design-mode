using UnityEngine;
using UnityEngine.EventSystems;

public class EventClick : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (NewBehaviourScript.iscolored == false)  //要是之前还没涂色的话
        {
            NewBehaviourScript.iscolored = true;
            NewBehaviourScript.tf = transform;  //保存组件
            NewBehaviourScript.color = transform.GetComponent<MeshRenderer>().material.color;//保存颜色
            transform.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else     //要是之前已经涂了色了
        {
            
            NewBehaviourScript.tf.GetComponent<MeshRenderer>().material.color = NewBehaviourScript.color;//还原之前的颜色

            NewBehaviourScript.color = transform.GetComponent<MeshRenderer>().material.color;//保存颜色
            
            
            transform.GetComponent<MeshRenderer>().material.color = Color.red;
            NewBehaviourScript.tf = transform;  //保存组件
        }
        
        
  
    }

}
