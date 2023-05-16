using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMuzzleFlash : MonoBehaviour {
    [SerializeField] private ParticleSystem flash;
    // Start is called before the first frame update
    void Start()
    {
        // flash.gameObject.SetActive(false);
        // flash.Play(false);
        // flash.Stop();
    }

    public void Fire() {
        // Debug.Log("Got Here");
        // ParticleSystem fl = Instantiate(flash, , Quaternion.identity);
        // Destroy(fl, 1f);

    }
    // Update is called once per frame
    void Update()
    {
           
    }
}
