using UnityEngine;

public class PanelKontrol : MonoBehaviour
{
    // Açıp kapatacağımız paneli buraya sürükleyeceğiz
    public GameObject ayarlarPaneli;

    // Oyun başladığında panelin kapalı olduğundan emin olalım
    void Start()
    {
        if (ayarlarPaneli != null)
        {
            ayarlarPaneli.SetActive(false); // Başlangıçta gizle
        }
    }

    // Ayarlar butonuna bağlanacak
    public void PaneliAc()
    {
        if (ayarlarPaneli != null)
        {
            ayarlarPaneli.SetActive(true); // Görünür yap
        }
    }

    // Çarpı (X) butonuna bağlanacak
    public void PaneliKapat()
    {
        if (ayarlarPaneli != null)
        {
            ayarlarPaneli.SetActive(false); // Gizle
        }
    }
}