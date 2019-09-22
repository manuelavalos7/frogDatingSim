using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSoundAnimation : MonoBehaviour
{
    private AudioSource click;
    private AudioSource select;
    // Start is called before the first frame update
    void Start()
    {
        click = gameObject.AddComponent<AudioSource>();
        select = gameObject.AddComponent<AudioSource>();
        click.clip = Resources.Load<AudioClip>("click");
        select.clip = Resources.Load<AudioClip>("select");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void selectButton(){
        select.Play();
    }

    public void hoverOverButton() {
        click.Play();
    }
}
