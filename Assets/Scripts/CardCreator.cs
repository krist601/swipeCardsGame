using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCreator : MonoBehaviour{
    public GameObject cardPrefab;

    void CreateCard(){
        GameObject newCard = Instantiate(cardPrefab, transform, false);
        newCard.transform.SetAsFirstSibling();
    }
    void Update(){
        if(transform.childCount < 2){
            CreateCard();
        }
    }
}
