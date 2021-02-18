using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public GameObject sonuçpanel;
    public static OyunKontrol oynkntrl;
    private void Awake()
    {
        if (oynkntrl == null)
        {
            oynkntrl = this;
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OyunBitti()
    {
        sonuçpanel.SetActive(true);
    }
}
