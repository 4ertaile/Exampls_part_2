using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour
{

    [SerializeField] private GameObject targetObject;
    [SerializeField] private string targetMessage;
    public Color higlightColor = Color.cyan;

    public void OnMouseEnter(){
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if(sprite != null)
            sprite.color = higlightColor;
    }
    public void OnMouseExit(){
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if(sprite != null)
        sprite.color = Color.white;
    }

    public void OnMouseDown(){
        transform.localScale = new Vector3(0.5f,0.5f,0.5f);
    } 

    public void OnMouseUp(){
        transform.localScale = new Vector3(0.4f,0.4f,0.5f);
        if(targetObject != null)
            targetObject.SendMessage(targetMessage);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
