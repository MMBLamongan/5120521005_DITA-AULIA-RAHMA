using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUtama : MonoBehaviour
{
    public GameObject Utama;
    public GameObject Panduan;
    public GameObject Marker;
    public GameObject Keluar;
    public GameObject About;

    // Start is called before the first frame update
    void Start()
    {
        Utama.SetActive (true);
        Panduan.SetActive (false);
    }

    public void PanduanClicked()
    {
        Utama.SetActive (false);
        Panduan.SetActive (true);
    }

    public void KembaliPanduanClicked()
    {
        Utama.SetActive (true);
        Panduan.SetActive (false);
    }

        public void MarkerClicked()
    {
        Utama.SetActive (false);
        Marker.SetActive (true);
    }

    public void KembaliMarkerClicked()
    {
        Utama.SetActive (true);
        Marker.SetActive (false);
    }

    public void AboutClicked()
    {
        Utama.SetActive (false);
        About.SetActive (true);
    }

    public void KembaliAboutClicked()
    {
        Utama.SetActive (true);
        About.SetActive (false);
    }

    public void KeluarClicked()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
