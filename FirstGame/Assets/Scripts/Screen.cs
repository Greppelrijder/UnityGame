using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour {

    [SerializeField] private string animParameterName;
    private Animator anim;

    private void Start() {
        this.anim = GetComponent<Animator>();
    }

    private void OnMouseOver() {
        anim.SetBool(animParameterName, true);
    }

    private void OnMouseExit() {
        anim.SetBool(animParameterName, false); 
    }
}
