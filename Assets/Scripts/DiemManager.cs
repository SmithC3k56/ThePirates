using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class DiemManager : MonoBehaviour
{
    public TMP_Text  diemText;
    private int diem = 0;

    void Start()
    {
        PlayerPrefs.SetInt("Diem", 0);
        // Đọc điểm từ PlayerPrefs khi khởi động
        diem = PlayerPrefs.GetInt("Diem", 0);
        UpdateDiemText();
    }

    public void CongDiem(int amount)
    {
        diem += amount;
        UpdateDiemText();

        // Lưu điểm vào PlayerPrefs
        PlayerPrefs.SetInt("Diem", diem);
        PlayerPrefs.Save();
    }

    void UpdateDiemText()
    {
        diemText.text =  diem.ToString();
    }
}