using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{
    [SerializeField]
    private GameObject popupGameover, crocBite;

    [SerializeField]
    private GameObject[] toothArr;

    private int decayToothIndex;

    void Start(){
        decayToothIndex = Random.Range(0, 10);
        popupGameover.SetActive(false);
        crocBite.SetActive(false);
    }

    public void onClickTooth(int toothIndex){
        if(toothIndex == decayToothIndex){
            crocBite.SetActive(true);
            popupGameover.SetActive(true);
        } else {
            toothArr[toothIndex].SetActive(false);
        }
    }

    public void onPlayAgain(){
        for(int i=0; i<10; i++){
            toothArr[i].SetActive(true);
        }
        decayToothIndex = Random.Range(0, 10);
        crocBite.SetActive(false);
        popupGameover.SetActive(false);
    }
}
