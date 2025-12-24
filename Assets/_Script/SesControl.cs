using UnityEngine;
using UnityEngine.UI; // Standart UI kütüphanesi

public class SesYoneticisi : MonoBehaviour
{
    [Header("Atamalar")]
    public Toggle sesToggle; // Sahnedeki Toggle objesi
    public Text labelText;   // Toggle'ın içindeki "Label" (Yazı) objesi

    void Start()
    {
        // 1. Oyun başladığında ses açık mı kontrol et
        // Eğer ses 0'dan büyükse 'true', değilse 'false' olur.
        bool sesAcik = AudioListener.volume > 0.01f;

        // 2. Toggle'ın tik durumunu buna eşitle
        if (sesToggle != null)
        {
            // Bu işlem OnValueChanged'i tetikleyebilir, sorun değil.
            sesToggle.isOn = sesAcik;
        }

        // 3. Yazıyı güncelle
        YaziyiGuncelle(sesAcik);
    }

    // Toggle'ın "On Value Changed" olayına bağlanacak fonksiyon
    public void SesDurumunuDegistir(bool acikMi)
    {
        if (acikMi)
        {
            AudioListener.volume = 1f; // Sesi Aç
        }
        else
        {
            AudioListener.volume = 0f; // Sesi Kapat
        }

        // Yazıyı anında güncelle
        YaziyiGuncelle(acikMi);

        // Konsoldan kontrol et (Çalışıp çalışmadığını görmek için)
        Debug.Log("Ses Durumu: " + (acikMi ? "AÇIK" : "KAPALI"));
    }

    // Kod tekrarı olmasın diye yardımcı fonksiyon
    void YaziyiGuncelle(bool acik)
    {
        if (labelText != null)
        {
            labelText.text = acik ? "Ses Açık" : "Ses Kapalı";
        }
    }
}