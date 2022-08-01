using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextCard : MonoBehaviour
{
    private SwipeEffect swipeEffect;
    private GameObject firstCard;

    private void Start(){
        swipeEffect = FindObjectOfType<SwipeEffect>();
        firstCard = swipeEffect.gameObject;
        swipeEffect.cardMoved += CardMovedFront;
        transform.localScale = new Vector3(firstCard.transform.localScale.x * 0.8f, firstCard.transform.localScale.y * 0.8f, firstCard.transform.localScale.z * 0.8f);
    }
    private void Update() {
        float distanceMoved = firstCard.transform.localPosition.x;
        if(Mathf.Abs(distanceMoved) > 0){
            float step = Mathf.SmoothStep(0.8f, 1 , Mathf.Abs(distanceMoved)/(Screen.width/2));
            transform.localScale = new Vector3(step, step, step);
        }
    }
    void CardMovedFront(){
        gameObject.AddComponent<SwipeEffect>();
        Destroy(this);
    }
}
